using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ChargesModel
{
    public struct Vect {
        public float x;
        public float y;
    }


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        float constK = 90000;
        static int fr_update = 33;
        int SHIFTCURX = 0;
        int SHIFTCURY = 22;
        static short VarColor = 1;

        Stack<string> hints = new Stack<string> { };

        public int DisplayForces = 0;
        public int DisplayVelocities = 0;
        public static int DisplayTrajectory = 0;

        public static int Limit(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static int ZeroAway(int num)
        {
            if (num == 0) return 1; return num;
        }

        public class Charge {
            public float Energy;
            public float Mass;
            public Vect Velocity;
            public Vect BuVelocity;
            public Vect Force;
            public Vect LastForce;

            public float X;
            public float BuX;
            public float Y;
            public float BuY;

            public bool IsPinned = false;


            public PictureBox pb;
            public Queue<Point> traj = new Queue<Point>();

            public Charge(float x, float y)
            {
                Energy = 2;
                Mass = 5;
                Vect temp;
                temp.x = 0;
                temp.y = 0;
                Velocity = temp;
                Force = temp;
                LastForce = temp;
                X = x;
                Y = y;
            }

            public Charge(float energy, float mass, Vect velocity)
            {
                Energy = energy;
                Mass = mass;
                Velocity = velocity;
            }

            public void BackUp()
            {
                BuX = X;
                BuY = Y;
                BuVelocity = Velocity;
            }

            public bool Restore()
            {
                X = BuX;
                Y = BuY;
                Velocity = BuVelocity;
                if ((X == 0) && (Y == 0)) return false;
                return true;
            }

            public int GetVelocity()
            {
                return (int)Math.Sqrt(Velocity.x * Velocity.x + Velocity.y * Velocity.y);
            }

            public int GetForce()
            {
                return (int)Math.Sqrt(LastForce.x * LastForce.x + LastForce.y * LastForce.y);
            }

            public void DrawColor()
            {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics grfx = Graphics.FromImage(bmp))
                {
                    grfx.Clear(Color.FromArgb(35, 35, 35));
                    RectangleF c_area = new RectangleF(0, 0, 15, 15);
                    switch (VarColor)
                    {
                        case 1:
                            grfx.FillEllipse(Brushes.White, c_area);
                            break;
                        case 2:
                            if (Energy >= 0)
                                grfx.FillEllipse(Brushes.IndianRed, c_area);
                            else
                                grfx.FillEllipse(Brushes.DeepSkyBlue, c_area);
                            break;
                        case 3:
                            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Limit(GetVelocity() * 3, 0, 255), Limit(GetVelocity() * 3, 0, 255), 255)), c_area);
                            break;
                        case 4:
                            grfx.FillEllipse(new SolidBrush(Color.FromArgb(255, Limit(GetForce() * 2, 0, 255), Limit(GetForce() * 2, 0, 255))), c_area);
                            break;
                        case 5:
                            if (Energy >= 0)
                                grfx.FillEllipse(new SolidBrush(Color.FromArgb(255 - Limit((int)Energy * 3, 0, 100), 255 - Limit((int)Energy * 5, 0, 100), 255 - Limit((int)Energy * 5, 0, 100))), c_area);
                            else
                                grfx.FillEllipse(new SolidBrush(Color.FromArgb(255 - Limit((int)Energy * 5, 0, 100), 255 - Limit((int)Energy * 5, 0, 100), 255 - Limit((int)Energy * 3, 0, 100))), c_area);
                            break;
                    }
                }
                if (VarColor != 6) pb.Image = bmp;
            }

            public void DrawSelf(PictureBox pictureBox)
            {
                pictureBox.Location = new Point((int)X, (int)Y);
                pictureBox.Visible = true;
                pb = pictureBox;
                DrawColor();
            }

            public void Move()
            {
                float a_x = Force.x / Mass;
                float a_y = Force.y / Mass;
                Velocity.x += a_x * fr_update / 1000;
                Velocity.y += a_y * fr_update / 1000;
                X += Velocity.x * fr_update / 1000;
                Y += Velocity.y * fr_update / 1000;
                pb.Location = new Point((int)X, (int)Y);
                traj.Enqueue(new Point((int)X, (int)Y));
                if ((traj.Count > 500) && (DisplayTrajectory != 1)) traj.Dequeue();

                DrawColor();
                LastForce = Force;
                Force.x = 0;
                Force.y = 0;
            }
        }


        //bool Drawing = true;
        //bool IsSimulationWorking = false;
        public PictureBox clickedPB;
        public Charge chosen;
        bool MovingCharge = false;



        List<Charge> charges = new List<Charge>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Point[] p_triangle = new Point[3];
            p_triangle[0].X = 0; p_triangle[0].Y = 0;
            p_triangle[1].X = 0; p_triangle[1].Y = 14;
            p_triangle[2].X = 8; p_triangle[2].Y = 7;

            Bitmap bmp = new Bitmap(20, 20);
            Bitmap vline = new Bitmap(500, 500);
            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                grfx.Clear(Color.FromArgb(35, 35, 35));
                RectangleF c_area = new RectangleF(0, 0, 15, 15);
                grfx.FillEllipse(Brushes.White, c_area);
            }

            using (Graphics gline = Graphics.FromImage(vline))
            {
                gline.Clear(Color.FromArgb(40, 40, 40));
                RectangleF c_area = new RectangleF(0, 0, 15, 15);
                Pen penline = new Pen(Brushes.White, 4);
                gline.DrawLine(penline, new Point(0, 0), new Point(500, 500));
            }
            charge0_PB.Image = bmp;
            charge1_PB.Image = bmp;
            LineSetPB.BackgroundImage = vline;
            hints.Push("Симуляция не запущена");
            hint_label.Text = hints.Peek();
        }

        private void Draw()
        {
            PictureBox[] obj_charges = { charge0_PB, charge1_PB,
            charge2_PB, charge3_PB, charge4_PB, charge5_PB,
            charge6_PB, charge7_PB, charge8_PB, charge9_PB};
            foreach (PictureBox item in obj_charges)
            {
                item.Visible = false;
            }
            int iter = 0;
            foreach (Charge item in charges)
            {
                item.DrawSelf(obj_charges[iter++]);
            }
        }


        public void ComputeForces(Charge current)
        {
            foreach (Charge item in charges)
            {
                if (item != current)
                {
                    Vect parforce;
                    float difx = item.X - current.X;
                    float dify = item.Y - current.Y;
                    double pf_length = Math.Sqrt(difx * difx + dify * dify);
                    float ch_cos = difx / (float)pf_length;
                    float ch_sin = dify / (float)pf_length;
                    pf_length = Math.Pow(pf_length, (double)NumLawLB.Value) * item.Energy * current.Energy * constK * (-1);
                    parforce.x = ch_cos * (float)pf_length;
                    parforce.y = ch_sin * (float)pf_length;
                    current.Force.x += parforce.x;
                    current.Force.y += parforce.y;
                }
            }
        }

        
        





        public PointF CirclePoint(float rad, float angle, PointF org)
        {
            float x = (float)(rad * Math.Cos(angle * Math.PI / 180F)) + org.X;
            float y = (float)(rad * Math.Sin(angle * Math.PI / 180F)) + org.Y;

            return new PointF(x, y);
        }

        private void CreateChargeItem_Click(object sender, EventArgs e)
        {
            if (charges.Count < 10)
            {
                charges.Add(new Charge(Cursor.Position.X - 5, Cursor.Position.Y - 28));
                Draw();
            } else
            {
                MessageBox.Show("Ой! Слишком много зарядиков(((");
            }
        }

        private void StartSimulation_Click(object sender, EventArgs e)
        {
            timer1.Interval = fr_update;
            //this.BackColor = Color.Black;
            PauseSimulation.Enabled = true;
            StopSimulation.Enabled = true;
            StartSimulation.Enabled = false;
            hints.Push("Симуляция запущена");
            hint_label.Text = hints.Peek();
            if (StartSimulation.Text == "Запустить симуляцию")
            foreach (Charge item in charges)
            {
                item.BackUp();
            }
            StartSimulation.Text = "Запустить симуляцию";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Charge item in charges)
            {
                if (!item.IsPinned)
                {
                    ComputeForces(item);
                    item.Move();
                }
            }
            Bitmap board = new Bitmap(Width, Height);



            if (DisplayForces == 2)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.LightBlue, 2);
                    foreach (Charge item in charges) {
                        if (item.IsPinned) continue;
                        gline.DrawLine(penline, new Point((int)item.X + 7, (int)item.Y + 7), new Point((int)item.X + 7 + (int)item.LastForce.x * 3, (int)item.Y + 7 + (int)item.LastForce.y * 3));
                    }
                }
                Blackboard.Visible = true;
            } else if (DisplayForces == 1)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.LightBlue, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.IsPinned) continue;
                        gline.DrawLine(penline, new Point((int)item.X + 7, (int)item.Y + 7), new Point((int)item.X + 7 + (int)(item.LastForce.x * 18 / ZeroAway(item.GetForce())), (int)item.Y + 7 + (int)(item.LastForce.y * 18 / ZeroAway(item.GetForce()))));
                    }
                }
                Blackboard.Visible = true;
            }



            if (DisplayVelocities == 2)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.PaleVioletRed, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.IsPinned) continue;
                        gline.DrawLine(penline, new Point((int)item.X + 7, (int)item.Y + 7), new Point((int)item.X + 7 + (int)item.Velocity.x * 3, (int)item.Y + 7 + (int)item.Velocity.y * 3));
                    }
                }
                Blackboard.Visible = true;
            }
            else if (DisplayVelocities == 1)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.PaleVioletRed, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.IsPinned) continue;
                        gline.DrawLine(penline, new Point((int)item.X + 7, (int)item.Y + 7), new Point((int)item.X + 7 + (int)(item.Velocity.x * 18 / ZeroAway(item.GetVelocity())), (int)item.Y + 7 + (int)(item.Velocity.y * 18 / ZeroAway(item.GetVelocity()))));
                    }
                }
                Blackboard.Visible = true;
            }


            if (DisplayTrajectory == 3)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.GreenYellow, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.traj.Count < 6) continue;
                        item.traj.Enqueue(new Point((int)item.X, (int)item.Y));
                        int dots = item.traj.Count;
                        //Point p1 = item.traj.Dequeue();
                        //if (item.traj.Count < 250) item.traj.Enqueue(p1);
                        //if (dots > 10)
                        for (int i = 0; i < dots - 1; i++)
                        {
                            Point p2 = item.traj.Dequeue();
                            item.traj.Enqueue(p2);
                            if ((i % (fr_update * 2)) != 0) continue;
                            RectangleF dot = new RectangleF(p2.X + 5, p2.Y + 5, 2, 2);
                            gline.DrawEllipse(penline, dot);
                            //p1 = p2;
                        }

                    }
                }
                Blackboard.Visible = true;
            }
            else if (DisplayTrajectory == 2)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.GreenYellow, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.traj.Count < 3) continue;
                        item.traj.Enqueue(new Point((int)item.X, (int)item.Y));
                        int dots = item.traj.Count;
                        Point p1 = item.traj.Dequeue();
                        if (item.traj.Count < 250) item.traj.Enqueue(p1);
                        for (int i = 0; i < dots - 1; i++)
                        {
                            Point p2 = item.traj.Dequeue();
                            item.traj.Enqueue(p2);
                            gline.DrawLine(penline, new Point(p1.X + 7, p1.Y + 7), new Point(p2.X + 7, p2.Y + 7));
                            p1 = p2;
                        }

                    }
                }
                Blackboard.Visible = true;
            }
            else if (DisplayTrajectory == 1)
            {
                using (Graphics gline = Graphics.FromImage(board))
                {
                    //gline.Clear(Color.FromArgb(40, 40, 40));
                    Pen penline = new Pen(Brushes.GreenYellow, 2);
                    foreach (Charge item in charges)
                    {
                        if (item.traj.Count < 3) continue;
                        item.traj.Enqueue(new Point((int)item.X, (int)item.Y));
                        int dots = item.traj.Count;
                        Point p1 = item.traj.Dequeue();
                        item.traj.Enqueue(p1);
                        for (int i = 0; i < dots - 1; i++)
                        {
                            Point p2 = item.traj.Dequeue();
                            item.traj.Enqueue(p2);
                            gline.DrawLine(penline, new Point(p1.X + 7, p1.Y + 7), new Point(p2.X + 7, p2.Y + 7));
                            p1 = p2;
                        }
                        
                    }
                }
                Blackboard.Visible = true;
            }



            Blackboard.Image = board;
            Blackboard.Location = new Point(0, 0);
            Blackboard.SendToBack();
            Blackboard.Width = Width;
            Blackboard.Height = Height;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void econst_TB_TextChanged(object sender, EventArgs e)
        {
            constK = float.Parse(econst_TB.Text);
        }

        private void Pin_Click(object sender, EventArgs e)
        {
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    item.IsPinned = !(item.IsPinned);
                    break;
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            //Text = charges[0].X.ToString();
            MovingCharge = false;
            clickedPB = contextMenuStrip2.SourceControl as PictureBox;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            Pin.Checked = chosen.IsPinned;
            ChargeIndicator.Text = "q = " + chosen.Energy;
            MassIndicator.Text = "m = " + chosen.Mass;
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            chosen.Energy *= -1;
            Draw();
        }

        private void PauseSimulation_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            StartSimulation.Text = "Продолжить симуляцию";
            StartSimulation.Enabled = true;
            PauseSimulation.Enabled = false;
            Blackboard.Visible = false;
            hints.Push("Симуляция приостановлена");
            hint_label.Text = hints.Peek();
        }

        private void StopSimulation_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            StartSimulation.Enabled = true;
            PauseSimulation.Enabled = false;
            StopSimulation.Enabled = false;
            Blackboard.Visible = false;
            foreach (Charge item in charges)
            {
                item.traj.Clear();
            }
            hint_label.Text = hints.Pop();
        }

        private void CreateChargeFromMenu_Click(object sender, EventArgs e)
        {
            charges.Add(new Charge(Width / 2, Height / 2));
            Draw();
        }


        private void SetVelocity_Click(object sender, EventArgs e)
        {
            Bitmap vline = new Bitmap(Width, Height);
            using (Graphics gline = Graphics.FromImage(vline))
            {
                gline.Clear(Color.FromArgb(40, 40, 40));
                Pen penline = new Pen(Brushes.White, 2);
                gline.DrawLine(penline, new Point(clickedPB.Location.X + clickedPB.Width / 2, clickedPB.Location.Y + clickedPB.Height / 2), new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY));
            }

            LineSetPB.Image = vline;
            LineSetPB.Location = new Point(0, 0);
            LineSetPB.SendToBack();
            LineSetPB.Width = Width;
            LineSetPB.Height = Height;
            LineSetPB.Visible = true;
            hints.Push("Длина линии равна расстоянию, которое пройдёт заряд за 2 секунды");
            hint_label.Text = hints.Peek();
            //SetLineClick = true;
            timer2.Start();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void LineSetPB_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Vect temp_vel;
            temp_vel.x = (Cursor.Position.X - SHIFTCURX - chosen.X) * 0.5f;
            temp_vel.y = (Cursor.Position.Y - SHIFTCURY - chosen.Y) * 0.5f;

            chosen.Velocity = temp_vel;
            LineSetPB.Visible = false;

            hints.Pop();
            hint_label.Text = hints.Peek();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Bitmap vline = new Bitmap(Width, Height);
            using (Graphics gline = Graphics.FromImage(vline))
            {
                gline.Clear(Color.FromArgb(40, 40, 40));
                Pen penline = new Pen(Brushes.CornflowerBlue, 2);
                gline.DrawLine(penline, new Point(clickedPB.Location.X + clickedPB.Width / 2, clickedPB.Location.Y + clickedPB.Height / 2), new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY));
            }

            LineSetPB.Image = vline;
        }

        private void charge0_PB_Click(object sender, EventArgs e)
        {

        }

        private void charge0_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge0_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            if (e.Button == MouseButtons.Left)
            MovingCharge = true;
        }

        private void charge0_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge0_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void WhiteCharges_Click(object sender, EventArgs e)
        {
            VarColor = 1;
            Draw();
            WhiteCharges.Checked = true;
            SignCharges.Checked = false;
            VelocityCharges.Checked = false;
            ForceCharges.Checked = false;
            EnergyCharges.Checked = false;
            DifferentColorsCharges.Checked = false;
            //PictureBox[] obj_charges = { charge0_PB, charge1_PB };

            Bitmap bmp = new Bitmap(20, 20);

            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                grfx.Clear(Color.FromArgb(35, 35, 35));
                RectangleF c_area = new RectangleF(0, 0, 15, 15);
                grfx.FillEllipse(Brushes.White, c_area);
            }

            //foreach (PictureBox item in obj_charges)
            //{
                //item.Image = bmp;
            //}
        }

        private void SignCharges_Click(object sender, EventArgs e)
        {
            VarColor = 2;
            Draw();
            WhiteCharges.Checked = false;
            SignCharges.Checked = true;
            VelocityCharges.Checked = false;
            ForceCharges.Checked = false;
            EnergyCharges.Checked = false;
            DifferentColorsCharges.Checked = false;


            RectangleF c_area = new RectangleF(0, 0, 15, 15);

            foreach (Charge item in charges)
            {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics grfx = Graphics.FromImage(bmp))
                {
                    grfx.Clear(Color.FromArgb(35, 35, 35));
                    if (item.Energy >= 0)
                        grfx.FillEllipse(Brushes.IndianRed, c_area);
                    else
                        grfx.FillEllipse(Brushes.DeepSkyBlue, c_area);
                }
                //item.pb.Image = bmp;
            }
        }

        private void charge1_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge1_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge1_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge1_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void SetChargeN50_Click(object sender, EventArgs e)
        {
            chosen.Energy = -50;
        }

        private void SetChargeN10_Click(object sender, EventArgs e)
        {
            chosen.Energy = -10;
        }

        private void SetChargeN5_Click(object sender, EventArgs e)
        {
            chosen.Energy = -5;
        }

        private void SetChargeN2_Click(object sender, EventArgs e)
        {
            chosen.Energy = -2;
        }

        private void SetChargeZero_Click(object sender, EventArgs e)
        {
            chosen.Energy = 0;
        }

        private void SetChargeP2_Click(object sender, EventArgs e)
        {
            chosen.Energy = 2;
        }

        private void SetChargeP5_Click(object sender, EventArgs e)
        {
            chosen.Energy = 5;
        }

        private void SetChargeP10_Click(object sender, EventArgs e)
        {
            chosen.Energy = 10;
        }

        private void SetChargeP50_Click(object sender, EventArgs e)
        {
            chosen.Energy = 50;
        }

        bool WaitSetCharge = true;
        private void SetChargeExactly_Click(object sender, EventArgs e)
        {
            SetPanel.Location = new Point(clickedPB.Location.X - 7, clickedPB.Location.Y - 7);
            SetPanel.SendToBack();
            WaitSetCharge = true;
            SetPanel.Visible = true;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (WaitSetCharge)
            {
                SetPanel.Visible = false;
                chosen.Energy = float.Parse(SetTB.Text);
            } else
            {
                SetPanel.Visible = false;
                chosen.Mass = float.Parse(SetTB.Text);
            }
        }

        private void SetMass20_Click(object sender, EventArgs e)
        {
            chosen.Mass = 20;
        }

        private void SetMass10_Click(object sender, EventArgs e)
        {
            chosen.Mass = 10;
        }

        private void SetMass5_Click(object sender, EventArgs e)
        {
            chosen.Mass = 5;
        }

        private void SetMass3_Click(object sender, EventArgs e)
        {
            chosen.Mass = 3;
        }

        private void SetMass2_Click(object sender, EventArgs e)
        {
            chosen.Mass = 2;
        }

        private void SetMass1_Click(object sender, EventArgs e)
        {
            chosen.Mass = 1;
        }

        private void SetMassHndrth_Click(object sender, EventArgs e)
        {
            chosen.Mass = 0.01f;
        }

        private void SetMassExactly_Click(object sender, EventArgs e)
        {
            SetPanel.Location = new Point(clickedPB.Location.X - 7, clickedPB.Location.Y - 7);
            SetPanel.SendToBack();
            WaitSetCharge = false;
            SetPanel.Visible = true;
        }

        private void DeleteCharge_Click(object sender, EventArgs e)
        {
            foreach (Charge item in charges)
            {
                if (item == chosen)
                {
                    charges.Remove(item);
                    Draw();
                    break;
                }
            }
        }

        private void charge2_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge2_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge3_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge3_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge4_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge4_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge5_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge5_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge6_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge6_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge7_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge7_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge8_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge8_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge9_PB_MouseDown(object sender, MouseEventArgs e)
        {
            clickedPB = charge9_PB;
            foreach (Charge item in charges)
            {
                if (item.pb == clickedPB)
                {
                    chosen = item;
                    break;
                }
            }
            MovingCharge = true;
        }

        private void charge2_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge3_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge4_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge5_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge6_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge7_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge8_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge9_PB_MouseUp(object sender, MouseEventArgs e)
        {
            MovingCharge = false;
            if (e.Button == MouseButtons.Left)
            {
                chosen.X = Cursor.Position.X - SHIFTCURX;
                chosen.Y = Cursor.Position.Y - SHIFTCURY;
            }
        }

        private void charge2_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge3_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge4_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge5_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge6_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge7_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge8_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void charge9_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovingCharge) clickedPB.Location = new Point(Cursor.Position.X - SHIFTCURX, Cursor.Position.Y - SHIFTCURY);
        }

        private void VelocityCharges_Click(object sender, EventArgs e)
        {
            VarColor = 3;
            Draw();
            WhiteCharges.Checked = false;
            SignCharges.Checked = false;
            VelocityCharges.Checked = true;
            ForceCharges.Checked = false;
            EnergyCharges.Checked = false;
            DifferentColorsCharges.Checked = false;
        }

        private void ForceCharges_Click(object sender, EventArgs e)
        {
            VarColor = 4;
            Draw();
            WhiteCharges.Checked = false;
            SignCharges.Checked = false;
            VelocityCharges.Checked = false;
            ForceCharges.Checked = true;
            EnergyCharges.Checked = false;
            DifferentColorsCharges.Checked = false;
        }

        private void EnergyCharges_Click(object sender, EventArgs e)
        {
            VarColor = 5;
            Draw();
            WhiteCharges.Checked = false;
            SignCharges.Checked = false;
            VelocityCharges.Checked = false;
            ForceCharges.Checked = false;
            EnergyCharges.Checked = true;
            DifferentColorsCharges.Checked = false;
        }

        private void DifferentColorsCharges_Click(object sender, EventArgs e)
        {
            VarColor = 6;
            Random rnd = new Random();
            
                foreach (Charge item in charges)
                {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics grfx = Graphics.FromImage(bmp))
                    {
                        
                        grfx.Clear(Color.FromArgb(35, 35, 35));
                        RectangleF c_area = new RectangleF(0, 0, 15, 15);
                        grfx.FillEllipse(new SolidBrush(Color.FromArgb(rnd.Next(1, 254), rnd.Next(1, 254), rnd.Next(1, 254))), c_area);
                        item.pb.Image = bmp;
                    }
                }

            WhiteCharges.Checked = false;
            SignCharges.Checked = false;
            VelocityCharges.Checked = false;
            ForceCharges.Checked = false;
            EnergyCharges.Checked = false;
            DifferentColorsCharges.Checked = true;
        }

        private void ResetSimulation_Click(object sender, EventArgs e)
        {
            restoring:
            foreach (Charge item in charges)
            {
                if (!item.Restore())
                {
                    charges.Remove(item);
                    goto restoring;
                    //break;
                }
                item.traj.Clear();
                Draw();
            }
        }

        private void DeleteAllCharges_Click(object sender, EventArgs e)
        {
            charges.Clear();
            Draw();
        }

        private void ShowForcesYes_Click(object sender, EventArgs e)
        {
            DisplayForces = 2;
            ShowForcesNo.Checked = false;
            ShowForcesOnlyDirections.Checked = false;
            ShowForcesYes.Checked = true;
        }

        private void ShowForcesOnlyDirections_Click(object sender, EventArgs e)
        {
            DisplayForces = 1;
            ShowForcesNo.Checked = false;
            ShowForcesOnlyDirections.Checked = true;
            ShowForcesYes.Checked = false;
        }

        private void ShowForcesNo_Click(object sender, EventArgs e)
        {
            DisplayForces = 0;
            ShowForcesNo.Checked = true;
            ShowForcesOnlyDirections.Checked = false;
            ShowForcesYes.Checked = false;
        }

        private void ShowVelocitiesNo_Click(object sender, EventArgs e)
        {
            DisplayVelocities = 0;
            ShowVelocitiesNo.Checked = true;
            ShowVelocitiesOnlyDirections.Checked = false;
            ShowVelocitiesYes.Checked = false;
        }

        private void ShowVelocitiesOnlyDirections_Click(object sender, EventArgs e)
        {
            DisplayVelocities = 1;
            ShowVelocitiesNo.Checked = false;
            ShowVelocitiesOnlyDirections.Checked = true;
            ShowVelocitiesYes.Checked = false;
        }

        private void ShowVelocitiesYes_Click(object sender, EventArgs e)
        {
            DisplayVelocities = 2;
            ShowVelocitiesNo.Checked = false;
            ShowVelocitiesOnlyDirections.Checked = false;
            ShowVelocitiesYes.Checked = true;
        }

        private void ShowTrajectorySolid_Click(object sender, EventArgs e)
        {
            DisplayTrajectory = 1;
            ShowTrajectoryDim.Checked = false;
            ShowTrajectoryDots.Checked = false;
            ShowTrajectoryNo.Checked = false;
            ShowTrajectorySolid.Checked = true;
        }

        private void ShowTrajectoryDim_Click(object sender, EventArgs e)
        {
            DisplayTrajectory = 2;
            ShowTrajectoryDim.Checked = true;
            ShowTrajectoryDots.Checked = false;
            ShowTrajectoryNo.Checked = false;
            ShowTrajectorySolid.Checked = false;
        }

        private void ShowTrajectoryDots_Click(object sender, EventArgs e)
        {
            DisplayTrajectory = 3;
            ShowTrajectoryDim.Checked = false;
            ShowTrajectoryDots.Checked = true;
            ShowTrajectoryNo.Checked = false;
            ShowTrajectorySolid.Checked = false;
        }

        private void ShowTrajectoryNo_Click(object sender, EventArgs e)
        {
            DisplayTrajectory = 0;
            ShowTrajectoryDim.Checked = false;
            ShowTrajectoryDots.Checked = false;
            ShowTrajectoryNo.Checked = true;
            ShowTrajectorySolid.Checked = false;
        }

        private void freqTB_TextChanged(object sender, EventArgs e)
        {
            fr_update = 1000 / Int16.Parse(freqTB.Text);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void CloseSettings_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        Charge trych;

        private void SrengthMap_Click(object sender, EventArgs e)
        {
            Bitmap board = new Bitmap(Width, Height);
            using (Graphics gline = Graphics.FromImage(board))
            {
                //gline.Clear(Color.FromArgb(40, 40, 40));
                Pen penline = new Pen(Brushes.LightBlue, 2);
                foreach (Charge item in charges)
                {
                    trych = new Charge(item.X, item.Y - 8);
                    trych.Energy = 1 * Math.Sign(item.Energy);
                    gline.DrawLine(penline, new Point((int)item.X + 7, (int)item.Y + 7), new Point((int)item.X + 7 + (int)item.LastForce.x * 3, (int)item.Y + 7 + (int)item.LastForce.y * 3));
                }
            }
            LineMap.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ComputeForces(trych);
            trych.Move();
        }
    }
}
