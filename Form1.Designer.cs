
namespace ChargesModel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.симуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.StopSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.зарядыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗарядToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.CreateChargeFromMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.отображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЗарядаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.SignCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.VelocityCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.ForceCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.EnergyCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.DifferentColorsCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.показыватьСилыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowForcesNo = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowForcesOnlyDirections = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowForcesYes = new System.Windows.Forms.ToolStripMenuItem();
            this.показыватьСкоростиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowVelocitiesNo = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowVelocitiesOnlyDirections = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowVelocitiesYes = new System.Windows.Forms.ToolStripMenuItem();
            this.отображатьТраекторииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTrajectoryNo = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTrajectorySolid = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTrajectoryDim = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTrajectoryDots = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseSettings = new System.Windows.Forms.Button();
            this.NumLawLB = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.freqTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.econst_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateChargeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charge0_PB = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChargeIndicator = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeN50 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeN10 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeN5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeN2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeZero = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeP2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeP5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeP10 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeP50 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetChargeExactly = new System.Windows.Forms.ToolStripMenuItem();
            this.MassIndicator = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass20 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass10 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMass1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMassHndrth = new System.Windows.Forms.ToolStripMenuItem();
            this.SetMassExactly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetVelocity = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSign = new System.Windows.Forms.ToolStripMenuItem();
            this.Pin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteCharge = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.charge1_PB = new System.Windows.Forms.PictureBox();
            this.LineSetPB = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.hint_label = new System.Windows.Forms.Label();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.SetButton = new System.Windows.Forms.Button();
            this.SetTB = new System.Windows.Forms.TextBox();
            this.charge2_PB = new System.Windows.Forms.PictureBox();
            this.charge3_PB = new System.Windows.Forms.PictureBox();
            this.charge4_PB = new System.Windows.Forms.PictureBox();
            this.charge5_PB = new System.Windows.Forms.PictureBox();
            this.charge6_PB = new System.Windows.Forms.PictureBox();
            this.charge7_PB = new System.Windows.Forms.PictureBox();
            this.charge8_PB = new System.Windows.Forms.PictureBox();
            this.charge9_PB = new System.Windows.Forms.PictureBox();
            this.Blackboard = new System.Windows.Forms.PictureBox();
            this.LineMap = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLawLB)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charge0_PB)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charge1_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineSetPB)).BeginInit();
            this.SetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charge2_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge3_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge4_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge5_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge6_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge7_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge8_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge9_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blackboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineMap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.симуляцияToolStripMenuItem,
            this.зарядыToolStripMenuItem,
            this.отображениеToolStripMenuItem,
            this.Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // симуляцияToolStripMenuItem
            // 
            this.симуляцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSimulation,
            this.PauseSimulation,
            this.StopSimulation,
            this.ResetSimulation});
            this.симуляцияToolStripMenuItem.Name = "симуляцияToolStripMenuItem";
            this.симуляцияToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.симуляцияToolStripMenuItem.Text = "Симуляция";
            // 
            // StartSimulation
            // 
            this.StartSimulation.Name = "StartSimulation";
            this.StartSimulation.Size = new System.Drawing.Size(227, 22);
            this.StartSimulation.Text = "Запустить симуляцию";
            this.StartSimulation.Click += new System.EventHandler(this.StartSimulation_Click);
            // 
            // PauseSimulation
            // 
            this.PauseSimulation.Enabled = false;
            this.PauseSimulation.Name = "PauseSimulation";
            this.PauseSimulation.Size = new System.Drawing.Size(227, 22);
            this.PauseSimulation.Text = "Приостановить симуляцию";
            this.PauseSimulation.Click += new System.EventHandler(this.PauseSimulation_Click);
            // 
            // StopSimulation
            // 
            this.StopSimulation.Enabled = false;
            this.StopSimulation.Name = "StopSimulation";
            this.StopSimulation.Size = new System.Drawing.Size(227, 22);
            this.StopSimulation.Text = "Остановить симуляцию";
            this.StopSimulation.Click += new System.EventHandler(this.StopSimulation_Click);
            // 
            // ResetSimulation
            // 
            this.ResetSimulation.Name = "ResetSimulation";
            this.ResetSimulation.Size = new System.Drawing.Size(227, 22);
            this.ResetSimulation.Text = "Сбросить";
            this.ResetSimulation.Click += new System.EventHandler(this.ResetSimulation_Click);
            // 
            // зарядыToolStripMenuItem
            // 
            this.зарядыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.создатьЗарядToolStripMenuItem,
            this.CreateChargeFromMenu,
            this.DeleteAllCharges});
            this.зарядыToolStripMenuItem.Name = "зарядыToolStripMenuItem";
            this.зарядыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.зарядыToolStripMenuItem.Text = "Заряды";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // создатьЗарядToolStripMenuItem
            // 
            this.создатьЗарядToolStripMenuItem.Name = "создатьЗарядToolStripMenuItem";
            this.создатьЗарядToolStripMenuItem.Size = new System.Drawing.Size(192, 6);
            // 
            // CreateChargeFromMenu
            // 
            this.CreateChargeFromMenu.Name = "CreateChargeFromMenu";
            this.CreateChargeFromMenu.Size = new System.Drawing.Size(195, 22);
            this.CreateChargeFromMenu.Text = "Создать заряд";
            this.CreateChargeFromMenu.Click += new System.EventHandler(this.CreateChargeFromMenu_Click);
            // 
            // DeleteAllCharges
            // 
            this.DeleteAllCharges.Name = "DeleteAllCharges";
            this.DeleteAllCharges.Size = new System.Drawing.Size(195, 22);
            this.DeleteAllCharges.Text = "Удалить все";
            this.DeleteAllCharges.Click += new System.EventHandler(this.DeleteAllCharges_Click);
            // 
            // отображениеToolStripMenuItem
            // 
            this.отображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветЗарядаToolStripMenuItem,
            this.показыватьСилыToolStripMenuItem,
            this.показыватьСкоростиToolStripMenuItem,
            this.отображатьТраекторииToolStripMenuItem});
            this.отображениеToolStripMenuItem.Name = "отображениеToolStripMenuItem";
            this.отображениеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.отображениеToolStripMenuItem.Text = "Отображение";
            // 
            // цветЗарядаToolStripMenuItem
            // 
            this.цветЗарядаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhiteCharges,
            this.SignCharges,
            this.VelocityCharges,
            this.ForceCharges,
            this.EnergyCharges,
            this.DifferentColorsCharges});
            this.цветЗарядаToolStripMenuItem.Name = "цветЗарядаToolStripMenuItem";
            this.цветЗарядаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.цветЗарядаToolStripMenuItem.Text = "Цвет заряда";
            // 
            // WhiteCharges
            // 
            this.WhiteCharges.Checked = true;
            this.WhiteCharges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WhiteCharges.Name = "WhiteCharges";
            this.WhiteCharges.Size = new System.Drawing.Size(180, 22);
            this.WhiteCharges.Text = "Белые";
            this.WhiteCharges.Click += new System.EventHandler(this.WhiteCharges_Click);
            // 
            // SignCharges
            // 
            this.SignCharges.Name = "SignCharges";
            this.SignCharges.Size = new System.Drawing.Size(180, 22);
            this.SignCharges.Text = "Знак";
            this.SignCharges.Click += new System.EventHandler(this.SignCharges_Click);
            // 
            // VelocityCharges
            // 
            this.VelocityCharges.Name = "VelocityCharges";
            this.VelocityCharges.Size = new System.Drawing.Size(180, 22);
            this.VelocityCharges.Text = "Скорость";
            this.VelocityCharges.Click += new System.EventHandler(this.VelocityCharges_Click);
            // 
            // ForceCharges
            // 
            this.ForceCharges.Name = "ForceCharges";
            this.ForceCharges.Size = new System.Drawing.Size(180, 22);
            this.ForceCharges.Text = "Сила";
            this.ForceCharges.Click += new System.EventHandler(this.ForceCharges_Click);
            // 
            // EnergyCharges
            // 
            this.EnergyCharges.Name = "EnergyCharges";
            this.EnergyCharges.Size = new System.Drawing.Size(180, 22);
            this.EnergyCharges.Text = "Заряд";
            this.EnergyCharges.Click += new System.EventHandler(this.EnergyCharges_Click);
            // 
            // DifferentColorsCharges
            // 
            this.DifferentColorsCharges.Name = "DifferentColorsCharges";
            this.DifferentColorsCharges.Size = new System.Drawing.Size(180, 22);
            this.DifferentColorsCharges.Text = "Разноцветные";
            this.DifferentColorsCharges.Click += new System.EventHandler(this.DifferentColorsCharges_Click);
            // 
            // показыватьСилыToolStripMenuItem
            // 
            this.показыватьСилыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowForcesNo,
            this.ShowForcesOnlyDirections,
            this.ShowForcesYes});
            this.показыватьСилыToolStripMenuItem.Name = "показыватьСилыToolStripMenuItem";
            this.показыватьСилыToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.показыватьСилыToolStripMenuItem.Text = "Показывать силы";
            // 
            // ShowForcesNo
            // 
            this.ShowForcesNo.Checked = true;
            this.ShowForcesNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowForcesNo.Name = "ShowForcesNo";
            this.ShowForcesNo.Size = new System.Drawing.Size(188, 22);
            this.ShowForcesNo.Text = "Нет";
            this.ShowForcesNo.Click += new System.EventHandler(this.ShowForcesNo_Click);
            // 
            // ShowForcesOnlyDirections
            // 
            this.ShowForcesOnlyDirections.Name = "ShowForcesOnlyDirections";
            this.ShowForcesOnlyDirections.Size = new System.Drawing.Size(188, 22);
            this.ShowForcesOnlyDirections.Text = "Только направление";
            this.ShowForcesOnlyDirections.Click += new System.EventHandler(this.ShowForcesOnlyDirections_Click);
            // 
            // ShowForcesYes
            // 
            this.ShowForcesYes.Name = "ShowForcesYes";
            this.ShowForcesYes.Size = new System.Drawing.Size(188, 22);
            this.ShowForcesYes.Text = "Да";
            this.ShowForcesYes.Click += new System.EventHandler(this.ShowForcesYes_Click);
            // 
            // показыватьСкоростиToolStripMenuItem
            // 
            this.показыватьСкоростиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowVelocitiesNo,
            this.ShowVelocitiesOnlyDirections,
            this.ShowVelocitiesYes});
            this.показыватьСкоростиToolStripMenuItem.Name = "показыватьСкоростиToolStripMenuItem";
            this.показыватьСкоростиToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.показыватьСкоростиToolStripMenuItem.Text = "Показывать скорости";
            // 
            // ShowVelocitiesNo
            // 
            this.ShowVelocitiesNo.Checked = true;
            this.ShowVelocitiesNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowVelocitiesNo.Name = "ShowVelocitiesNo";
            this.ShowVelocitiesNo.Size = new System.Drawing.Size(188, 22);
            this.ShowVelocitiesNo.Text = "Нет";
            this.ShowVelocitiesNo.Click += new System.EventHandler(this.ShowVelocitiesNo_Click);
            // 
            // ShowVelocitiesOnlyDirections
            // 
            this.ShowVelocitiesOnlyDirections.Name = "ShowVelocitiesOnlyDirections";
            this.ShowVelocitiesOnlyDirections.Size = new System.Drawing.Size(188, 22);
            this.ShowVelocitiesOnlyDirections.Text = "Только направления";
            this.ShowVelocitiesOnlyDirections.Click += new System.EventHandler(this.ShowVelocitiesOnlyDirections_Click);
            // 
            // ShowVelocitiesYes
            // 
            this.ShowVelocitiesYes.Name = "ShowVelocitiesYes";
            this.ShowVelocitiesYes.Size = new System.Drawing.Size(188, 22);
            this.ShowVelocitiesYes.Text = "Да";
            this.ShowVelocitiesYes.Click += new System.EventHandler(this.ShowVelocitiesYes_Click);
            // 
            // отображатьТраекторииToolStripMenuItem
            // 
            this.отображатьТраекторииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTrajectoryNo,
            this.ShowTrajectorySolid,
            this.ShowTrajectoryDim,
            this.ShowTrajectoryDots});
            this.отображатьТраекторииToolStripMenuItem.Name = "отображатьТраекторииToolStripMenuItem";
            this.отображатьТраекторииToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.отображатьТраекторииToolStripMenuItem.Text = "Отображать траектории";
            // 
            // ShowTrajectoryNo
            // 
            this.ShowTrajectoryNo.Checked = true;
            this.ShowTrajectoryNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowTrajectoryNo.Name = "ShowTrajectoryNo";
            this.ShowTrajectoryNo.Size = new System.Drawing.Size(188, 22);
            this.ShowTrajectoryNo.Text = "Нет";
            this.ShowTrajectoryNo.Click += new System.EventHandler(this.ShowTrajectoryNo_Click);
            // 
            // ShowTrajectorySolid
            // 
            this.ShowTrajectorySolid.Name = "ShowTrajectorySolid";
            this.ShowTrajectorySolid.Size = new System.Drawing.Size(188, 22);
            this.ShowTrajectorySolid.Text = "Неугасающая линия";
            this.ShowTrajectorySolid.Click += new System.EventHandler(this.ShowTrajectorySolid_Click);
            // 
            // ShowTrajectoryDim
            // 
            this.ShowTrajectoryDim.Name = "ShowTrajectoryDim";
            this.ShowTrajectoryDim.Size = new System.Drawing.Size(188, 22);
            this.ShowTrajectoryDim.Text = "Угасающая линия";
            this.ShowTrajectoryDim.Click += new System.EventHandler(this.ShowTrajectoryDim_Click);
            // 
            // ShowTrajectoryDots
            // 
            this.ShowTrajectoryDots.Name = "ShowTrajectoryDots";
            this.ShowTrajectoryDots.Size = new System.Drawing.Size(188, 22);
            this.ShowTrajectoryDots.Text = "Точки";
            this.ShowTrajectoryDots.Click += new System.EventHandler(this.ShowTrajectoryDots_Click);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(79, 20);
            this.Settings.Text = "Настройки";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CloseSettings);
            this.panel1.Controls.Add(this.NumLawLB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.freqTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.econst_TB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(753, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 184);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "Изменения применяются автоматически";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CloseSettings
            // 
            this.CloseSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseSettings.Location = new System.Drawing.Point(265, 151);
            this.CloseSettings.Name = "CloseSettings";
            this.CloseSettings.Size = new System.Drawing.Size(86, 25);
            this.CloseSettings.TabIndex = 8;
            this.CloseSettings.Text = "Закрыть";
            this.CloseSettings.UseVisualStyleBackColor = true;
            this.CloseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
            // 
            // NumLawLB
            // 
            this.NumLawLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumLawLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLawLB.Location = new System.Drawing.Point(175, 100);
            this.NumLawLB.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumLawLB.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.NumLawLB.Name = "NumLawLB";
            this.NumLawLB.Size = new System.Drawing.Size(44, 23);
            this.NumLawLB.TabIndex = 7;
            this.NumLawLB.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Закон взаимодействия";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // freqTB
            // 
            this.freqTB.Location = new System.Drawing.Point(193, 69);
            this.freqTB.Name = "freqTB";
            this.freqTB.Size = new System.Drawing.Size(92, 20);
            this.freqTB.TabIndex = 5;
            this.freqTB.Text = "30";
            this.freqTB.TextChanged += new System.EventHandler(this.freqTB_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(173, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "1/";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Частота дискретизации";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // econst_TB
            // 
            this.econst_TB.Location = new System.Drawing.Point(176, 41);
            this.econst_TB.Name = "econst_TB";
            this.econst_TB.Size = new System.Drawing.Size(158, 20);
            this.econst_TB.TabIndex = 2;
            this.econst_TB.Text = "90000";
            this.econst_TB.TextChanged += new System.EventHandler(this.econst_TB_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Эл. постоянная";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateChargeItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // CreateChargeItem
            // 
            this.CreateChargeItem.Name = "CreateChargeItem";
            this.CreateChargeItem.Size = new System.Drawing.Size(150, 22);
            this.CreateChargeItem.Text = "Создать заряд";
            this.CreateChargeItem.Click += new System.EventHandler(this.CreateChargeItem_Click);
            // 
            // charge0_PB
            // 
            this.charge0_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge0_PB.Location = new System.Drawing.Point(266, 226);
            this.charge0_PB.Name = "charge0_PB";
            this.charge0_PB.Size = new System.Drawing.Size(15, 15);
            this.charge0_PB.TabIndex = 3;
            this.charge0_PB.TabStop = false;
            this.charge0_PB.Visible = false;
            this.charge0_PB.Click += new System.EventHandler(this.charge0_PB_Click);
            this.charge0_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge0_PB_MouseDown);
            this.charge0_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge0_PB_MouseMove);
            this.charge0_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge0_PB_MouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChargeIndicator,
            this.MassIndicator,
            this.toolStripMenuItem1,
            this.SetVelocity,
            this.ChangeSign,
            this.Pin,
            this.toolStripMenuItem2,
            this.DeleteCharge});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(164, 148);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // ChargeIndicator
            // 
            this.ChargeIndicator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetChargeN50,
            this.SetChargeN10,
            this.SetChargeN5,
            this.SetChargeN2,
            this.SetChargeZero,
            this.SetChargeP2,
            this.SetChargeP5,
            this.SetChargeP10,
            this.SetChargeP50,
            this.SetChargeExactly});
            this.ChargeIndicator.Name = "ChargeIndicator";
            this.ChargeIndicator.Size = new System.Drawing.Size(163, 22);
            this.ChargeIndicator.Text = "q = ?";
            // 
            // SetChargeN50
            // 
            this.SetChargeN50.Name = "SetChargeN50";
            this.SetChargeN50.Size = new System.Drawing.Size(117, 22);
            this.SetChargeN50.Text = "-50";
            this.SetChargeN50.Click += new System.EventHandler(this.SetChargeN50_Click);
            // 
            // SetChargeN10
            // 
            this.SetChargeN10.Name = "SetChargeN10";
            this.SetChargeN10.Size = new System.Drawing.Size(117, 22);
            this.SetChargeN10.Text = "-10";
            this.SetChargeN10.Click += new System.EventHandler(this.SetChargeN10_Click);
            // 
            // SetChargeN5
            // 
            this.SetChargeN5.Name = "SetChargeN5";
            this.SetChargeN5.Size = new System.Drawing.Size(117, 22);
            this.SetChargeN5.Text = "-5";
            this.SetChargeN5.Click += new System.EventHandler(this.SetChargeN5_Click);
            // 
            // SetChargeN2
            // 
            this.SetChargeN2.Name = "SetChargeN2";
            this.SetChargeN2.Size = new System.Drawing.Size(117, 22);
            this.SetChargeN2.Text = "-2";
            this.SetChargeN2.Click += new System.EventHandler(this.SetChargeN2_Click);
            // 
            // SetChargeZero
            // 
            this.SetChargeZero.Name = "SetChargeZero";
            this.SetChargeZero.Size = new System.Drawing.Size(117, 22);
            this.SetChargeZero.Text = "0";
            this.SetChargeZero.Click += new System.EventHandler(this.SetChargeZero_Click);
            // 
            // SetChargeP2
            // 
            this.SetChargeP2.Name = "SetChargeP2";
            this.SetChargeP2.Size = new System.Drawing.Size(117, 22);
            this.SetChargeP2.Text = "2";
            this.SetChargeP2.Click += new System.EventHandler(this.SetChargeP2_Click);
            // 
            // SetChargeP5
            // 
            this.SetChargeP5.Name = "SetChargeP5";
            this.SetChargeP5.Size = new System.Drawing.Size(117, 22);
            this.SetChargeP5.Text = "5";
            this.SetChargeP5.Click += new System.EventHandler(this.SetChargeP5_Click);
            // 
            // SetChargeP10
            // 
            this.SetChargeP10.Name = "SetChargeP10";
            this.SetChargeP10.Size = new System.Drawing.Size(117, 22);
            this.SetChargeP10.Text = "10";
            this.SetChargeP10.Click += new System.EventHandler(this.SetChargeP10_Click);
            // 
            // SetChargeP50
            // 
            this.SetChargeP50.Name = "SetChargeP50";
            this.SetChargeP50.Size = new System.Drawing.Size(117, 22);
            this.SetChargeP50.Text = "50";
            this.SetChargeP50.Click += new System.EventHandler(this.SetChargeP50_Click);
            // 
            // SetChargeExactly
            // 
            this.SetChargeExactly.Name = "SetChargeExactly";
            this.SetChargeExactly.Size = new System.Drawing.Size(117, 22);
            this.SetChargeExactly.Text = "Точно...";
            this.SetChargeExactly.Click += new System.EventHandler(this.SetChargeExactly_Click);
            // 
            // MassIndicator
            // 
            this.MassIndicator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetMass20,
            this.SetMass10,
            this.SetMass5,
            this.SetMass3,
            this.SetMass2,
            this.SetMass1,
            this.SetMassHndrth,
            this.SetMassExactly});
            this.MassIndicator.Name = "MassIndicator";
            this.MassIndicator.Size = new System.Drawing.Size(163, 22);
            this.MassIndicator.Text = "m = ?";
            // 
            // SetMass20
            // 
            this.SetMass20.Name = "SetMass20";
            this.SetMass20.Size = new System.Drawing.Size(117, 22);
            this.SetMass20.Text = "20";
            this.SetMass20.Click += new System.EventHandler(this.SetMass20_Click);
            // 
            // SetMass10
            // 
            this.SetMass10.Name = "SetMass10";
            this.SetMass10.Size = new System.Drawing.Size(117, 22);
            this.SetMass10.Text = "10";
            this.SetMass10.Click += new System.EventHandler(this.SetMass10_Click);
            // 
            // SetMass5
            // 
            this.SetMass5.Name = "SetMass5";
            this.SetMass5.Size = new System.Drawing.Size(117, 22);
            this.SetMass5.Text = "5";
            this.SetMass5.Click += new System.EventHandler(this.SetMass5_Click);
            // 
            // SetMass3
            // 
            this.SetMass3.Name = "SetMass3";
            this.SetMass3.Size = new System.Drawing.Size(117, 22);
            this.SetMass3.Text = "3";
            this.SetMass3.Click += new System.EventHandler(this.SetMass3_Click);
            // 
            // SetMass2
            // 
            this.SetMass2.Name = "SetMass2";
            this.SetMass2.Size = new System.Drawing.Size(117, 22);
            this.SetMass2.Text = "2";
            this.SetMass2.Click += new System.EventHandler(this.SetMass2_Click);
            // 
            // SetMass1
            // 
            this.SetMass1.Name = "SetMass1";
            this.SetMass1.Size = new System.Drawing.Size(117, 22);
            this.SetMass1.Text = "1";
            this.SetMass1.Click += new System.EventHandler(this.SetMass1_Click);
            // 
            // SetMassHndrth
            // 
            this.SetMassHndrth.Name = "SetMassHndrth";
            this.SetMassHndrth.Size = new System.Drawing.Size(117, 22);
            this.SetMassHndrth.Text = "0,01";
            this.SetMassHndrth.Click += new System.EventHandler(this.SetMassHndrth_Click);
            // 
            // SetMassExactly
            // 
            this.SetMassExactly.Name = "SetMassExactly";
            this.SetMassExactly.Size = new System.Drawing.Size(117, 22);
            this.SetMassExactly.Text = "Точно...";
            this.SetMassExactly.Click += new System.EventHandler(this.SetMassExactly_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // SetVelocity
            // 
            this.SetVelocity.Name = "SetVelocity";
            this.SetVelocity.Size = new System.Drawing.Size(163, 22);
            this.SetVelocity.Text = "Задать скорость";
            this.SetVelocity.Click += new System.EventHandler(this.SetVelocity_Click);
            // 
            // ChangeSign
            // 
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.Size = new System.Drawing.Size(163, 22);
            this.ChangeSign.Text = "Сменить знак";
            this.ChangeSign.Click += new System.EventHandler(this.ChangeSign_Click);
            // 
            // Pin
            // 
            this.Pin.CheckOnClick = true;
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(163, 22);
            this.Pin.Text = "Приколотить";
            this.Pin.Click += new System.EventHandler(this.Pin_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // DeleteCharge
            // 
            this.DeleteCharge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteCharge.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteCharge.Name = "DeleteCharge";
            this.DeleteCharge.Size = new System.Drawing.Size(163, 22);
            this.DeleteCharge.Text = "Удалить";
            this.DeleteCharge.Click += new System.EventHandler(this.DeleteCharge_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // charge1_PB
            // 
            this.charge1_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge1_PB.Location = new System.Drawing.Point(266, 254);
            this.charge1_PB.Name = "charge1_PB";
            this.charge1_PB.Size = new System.Drawing.Size(15, 15);
            this.charge1_PB.TabIndex = 4;
            this.charge1_PB.TabStop = false;
            this.charge1_PB.Visible = false;
            this.charge1_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge1_PB_MouseDown);
            this.charge1_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge1_PB_MouseMove);
            this.charge1_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge1_PB_MouseUp);
            // 
            // LineSetPB
            // 
            this.LineSetPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineSetPB.Location = new System.Drawing.Point(662, 358);
            this.LineSetPB.Name = "LineSetPB";
            this.LineSetPB.Size = new System.Drawing.Size(197, 101);
            this.LineSetPB.TabIndex = 6;
            this.LineSetPB.TabStop = false;
            this.LineSetPB.Visible = false;
            this.LineSetPB.Click += new System.EventHandler(this.LineSetPB_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // hint_label
            // 
            this.hint_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hint_label.AutoSize = true;
            this.hint_label.ForeColor = System.Drawing.Color.White;
            this.hint_label.Location = new System.Drawing.Point(12, 605);
            this.hint_label.Name = "hint_label";
            this.hint_label.Size = new System.Drawing.Size(131, 13);
            this.hint_label.TabIndex = 7;
            this.hint_label.Text = "Симуляция не запущена";
            // 
            // SetPanel
            // 
            this.SetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetPanel.Controls.Add(this.SetButton);
            this.SetPanel.Controls.Add(this.SetTB);
            this.SetPanel.Location = new System.Drawing.Point(644, 254);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(130, 76);
            this.SetPanel.TabIndex = 8;
            this.SetPanel.Visible = false;
            // 
            // SetButton
            // 
            this.SetButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetButton.Location = new System.Drawing.Point(30, 34);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(89, 25);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Установить";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // SetTB
            // 
            this.SetTB.Location = new System.Drawing.Point(31, 10);
            this.SetTB.Name = "SetTB";
            this.SetTB.Size = new System.Drawing.Size(89, 20);
            this.SetTB.TabIndex = 6;
            this.SetTB.Text = "30";
            // 
            // charge2_PB
            // 
            this.charge2_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge2_PB.Location = new System.Drawing.Point(266, 275);
            this.charge2_PB.Name = "charge2_PB";
            this.charge2_PB.Size = new System.Drawing.Size(15, 15);
            this.charge2_PB.TabIndex = 9;
            this.charge2_PB.TabStop = false;
            this.charge2_PB.Visible = false;
            this.charge2_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge2_PB_MouseDown);
            this.charge2_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge2_PB_MouseMove);
            this.charge2_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge2_PB_MouseUp);
            // 
            // charge3_PB
            // 
            this.charge3_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge3_PB.Location = new System.Drawing.Point(266, 299);
            this.charge3_PB.Name = "charge3_PB";
            this.charge3_PB.Size = new System.Drawing.Size(15, 15);
            this.charge3_PB.TabIndex = 10;
            this.charge3_PB.TabStop = false;
            this.charge3_PB.Visible = false;
            this.charge3_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge3_PB_MouseDown);
            this.charge3_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge3_PB_MouseMove);
            this.charge3_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge3_PB_MouseUp);
            // 
            // charge4_PB
            // 
            this.charge4_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge4_PB.Location = new System.Drawing.Point(266, 320);
            this.charge4_PB.Name = "charge4_PB";
            this.charge4_PB.Size = new System.Drawing.Size(15, 15);
            this.charge4_PB.TabIndex = 11;
            this.charge4_PB.TabStop = false;
            this.charge4_PB.Visible = false;
            this.charge4_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge4_PB_MouseDown);
            this.charge4_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge4_PB_MouseMove);
            this.charge4_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge4_PB_MouseUp);
            // 
            // charge5_PB
            // 
            this.charge5_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge5_PB.Location = new System.Drawing.Point(266, 341);
            this.charge5_PB.Name = "charge5_PB";
            this.charge5_PB.Size = new System.Drawing.Size(15, 15);
            this.charge5_PB.TabIndex = 12;
            this.charge5_PB.TabStop = false;
            this.charge5_PB.Visible = false;
            this.charge5_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge5_PB_MouseDown);
            this.charge5_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge5_PB_MouseMove);
            this.charge5_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge5_PB_MouseUp);
            // 
            // charge6_PB
            // 
            this.charge6_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge6_PB.Location = new System.Drawing.Point(266, 362);
            this.charge6_PB.Name = "charge6_PB";
            this.charge6_PB.Size = new System.Drawing.Size(15, 15);
            this.charge6_PB.TabIndex = 13;
            this.charge6_PB.TabStop = false;
            this.charge6_PB.Visible = false;
            this.charge6_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge6_PB_MouseDown);
            this.charge6_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge6_PB_MouseMove);
            this.charge6_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge6_PB_MouseUp);
            // 
            // charge7_PB
            // 
            this.charge7_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge7_PB.Location = new System.Drawing.Point(266, 383);
            this.charge7_PB.Name = "charge7_PB";
            this.charge7_PB.Size = new System.Drawing.Size(15, 15);
            this.charge7_PB.TabIndex = 14;
            this.charge7_PB.TabStop = false;
            this.charge7_PB.Visible = false;
            this.charge7_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge7_PB_MouseDown);
            this.charge7_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge7_PB_MouseMove);
            this.charge7_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge7_PB_MouseUp);
            // 
            // charge8_PB
            // 
            this.charge8_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge8_PB.Location = new System.Drawing.Point(266, 414);
            this.charge8_PB.Name = "charge8_PB";
            this.charge8_PB.Size = new System.Drawing.Size(15, 15);
            this.charge8_PB.TabIndex = 15;
            this.charge8_PB.TabStop = false;
            this.charge8_PB.Visible = false;
            this.charge8_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge8_PB_MouseDown);
            this.charge8_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge8_PB_MouseMove);
            this.charge8_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge8_PB_MouseUp);
            // 
            // charge9_PB
            // 
            this.charge9_PB.ContextMenuStrip = this.contextMenuStrip2;
            this.charge9_PB.Location = new System.Drawing.Point(266, 435);
            this.charge9_PB.Name = "charge9_PB";
            this.charge9_PB.Size = new System.Drawing.Size(15, 15);
            this.charge9_PB.TabIndex = 16;
            this.charge9_PB.TabStop = false;
            this.charge9_PB.Visible = false;
            this.charge9_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charge9_PB_MouseDown);
            this.charge9_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.charge9_PB_MouseMove);
            this.charge9_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.charge9_PB_MouseUp);
            // 
            // Blackboard
            // 
            this.Blackboard.Location = new System.Drawing.Point(897, 309);
            this.Blackboard.Name = "Blackboard";
            this.Blackboard.Size = new System.Drawing.Size(141, 126);
            this.Blackboard.TabIndex = 17;
            this.Blackboard.TabStop = false;
            this.Blackboard.Visible = false;
            // 
            // LineMap
            // 
            this.LineMap.Location = new System.Drawing.Point(897, 452);
            this.LineMap.Name = "LineMap";
            this.LineMap.Size = new System.Drawing.Size(141, 126);
            this.LineMap.TabIndex = 18;
            this.LineMap.TabStop = false;
            this.LineMap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1124, 627);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LineMap);
            this.Controls.Add(this.Blackboard);
            this.Controls.Add(this.charge9_PB);
            this.Controls.Add(this.charge8_PB);
            this.Controls.Add(this.charge7_PB);
            this.Controls.Add(this.charge6_PB);
            this.Controls.Add(this.charge5_PB);
            this.Controls.Add(this.charge4_PB);
            this.Controls.Add(this.charge3_PB);
            this.Controls.Add(this.charge2_PB);
            this.Controls.Add(this.SetPanel);
            this.Controls.Add(this.hint_label);
            this.Controls.Add(this.LineSetPB);
            this.Controls.Add(this.charge1_PB);
            this.Controls.Add(this.charge0_PB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLawLB)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charge0_PB)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charge1_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineSetPB)).EndInit();
            this.SetPanel.ResumeLayout(false);
            this.SetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charge2_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge3_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge4_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge5_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge6_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge7_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge8_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charge9_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blackboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem симуляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartSimulation;
        private System.Windows.Forms.ToolStripMenuItem PauseSimulation;
        private System.Windows.Forms.ToolStripMenuItem StopSimulation;
        private System.Windows.Forms.ToolStripMenuItem ResetSimulation;
        private System.Windows.Forms.ToolStripMenuItem зарядыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripSeparator создатьЗарядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateChargeFromMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllCharges;
        private System.Windows.Forms.ToolStripMenuItem цветЗарядаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WhiteCharges;
        private System.Windows.Forms.ToolStripMenuItem SignCharges;
        private System.Windows.Forms.ToolStripMenuItem VelocityCharges;
        private System.Windows.Forms.ToolStripMenuItem ForceCharges;
        private System.Windows.Forms.ToolStripMenuItem EnergyCharges;
        private System.Windows.Forms.ToolStripMenuItem DifferentColorsCharges;
        private System.Windows.Forms.ToolStripMenuItem показыватьСилыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowForcesNo;
        private System.Windows.Forms.ToolStripMenuItem ShowForcesOnlyDirections;
        private System.Windows.Forms.ToolStripMenuItem ShowForcesYes;
        private System.Windows.Forms.ToolStripMenuItem показыватьСкоростиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowVelocitiesNo;
        private System.Windows.Forms.ToolStripMenuItem ShowVelocitiesOnlyDirections;
        private System.Windows.Forms.ToolStripMenuItem ShowVelocitiesYes;
        private System.Windows.Forms.ToolStripMenuItem отображатьТраекторииToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox econst_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox freqTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateChargeItem;
        private System.Windows.Forms.PictureBox charge0_PB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox charge1_PB;
        private System.Windows.Forms.NumericUpDown NumLawLB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ChargeIndicator;
        private System.Windows.Forms.ToolStripMenuItem SetChargeN50;
        private System.Windows.Forms.ToolStripMenuItem SetChargeN10;
        private System.Windows.Forms.ToolStripMenuItem SetChargeN5;
        private System.Windows.Forms.ToolStripMenuItem SetChargeN2;
        private System.Windows.Forms.ToolStripMenuItem SetChargeZero;
        private System.Windows.Forms.ToolStripMenuItem SetChargeP2;
        private System.Windows.Forms.ToolStripMenuItem SetChargeP5;
        private System.Windows.Forms.ToolStripMenuItem SetChargeP10;
        private System.Windows.Forms.ToolStripMenuItem SetChargeP50;
        private System.Windows.Forms.ToolStripMenuItem SetChargeExactly;
        private System.Windows.Forms.ToolStripMenuItem MassIndicator;
        private System.Windows.Forms.ToolStripMenuItem SetMass20;
        private System.Windows.Forms.ToolStripMenuItem SetMass10;
        private System.Windows.Forms.ToolStripMenuItem SetMass5;
        private System.Windows.Forms.ToolStripMenuItem SetMass3;
        private System.Windows.Forms.ToolStripMenuItem SetMass2;
        private System.Windows.Forms.ToolStripMenuItem SetMass1;
        private System.Windows.Forms.ToolStripMenuItem SetMassHndrth;
        private System.Windows.Forms.ToolStripMenuItem SetMassExactly;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SetVelocity;
        private System.Windows.Forms.ToolStripMenuItem ChangeSign;
        private System.Windows.Forms.ToolStripMenuItem Pin;
        private System.Windows.Forms.PictureBox LineSetPB;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label hint_label;
        private System.Windows.Forms.Panel SetPanel;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox SetTB;
        private System.Windows.Forms.PictureBox charge2_PB;
        private System.Windows.Forms.PictureBox charge3_PB;
        private System.Windows.Forms.PictureBox charge4_PB;
        private System.Windows.Forms.PictureBox charge5_PB;
        private System.Windows.Forms.PictureBox charge6_PB;
        private System.Windows.Forms.PictureBox charge7_PB;
        private System.Windows.Forms.PictureBox charge8_PB;
        private System.Windows.Forms.PictureBox charge9_PB;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DeleteCharge;
        private System.Windows.Forms.PictureBox Blackboard;
        private System.Windows.Forms.ToolStripMenuItem ShowTrajectoryNo;
        private System.Windows.Forms.ToolStripMenuItem ShowTrajectorySolid;
        private System.Windows.Forms.ToolStripMenuItem ShowTrajectoryDim;
        private System.Windows.Forms.ToolStripMenuItem ShowTrajectoryDots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseSettings;
        private System.Windows.Forms.PictureBox LineMap;
    }
}

