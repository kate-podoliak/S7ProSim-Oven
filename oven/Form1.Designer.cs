
namespace oven
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_I00 = new System.Windows.Forms.CheckBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.checkBox_I01 = new System.Windows.Forms.CheckBox();
            this.checkBox_I02 = new System.Windows.Forms.CheckBox();
            this.label_Q00 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.timer_Read_Output = new System.Windows.Forms.Timer(this.components);
            this.checkBox_I03 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_I00
            // 
            this.checkBox_I00.AutoSize = true;
            this.checkBox_I00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_I00.Location = new System.Drawing.Point(375, 88);
            this.checkBox_I00.Name = "checkBox_I00";
            this.checkBox_I00.Size = new System.Drawing.Size(183, 29);
            this.checkBox_I00.TabIndex = 1;
            this.checkBox_I00.Text = "ДАТЧИК ТИСКУ";
            this.checkBox_I00.UseVisualStyleBackColor = true;
            this.checkBox_I00.CheckedChanged += new System.EventHandler(this.checkBox_I00_CheckedChanged);
            // 
            // button_Run
            // 
            this.button_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Run.Location = new System.Drawing.Point(375, 246);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(150, 35);
            this.button_Run.TabIndex = 4;
            this.button_Run.Text = "ЗАПУСКАТИ";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Stop.Location = new System.Drawing.Point(535, 246);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(135, 35);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "СТОП";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // checkBox_I01
            // 
            this.checkBox_I01.AutoSize = true;
            this.checkBox_I01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_I01.Location = new System.Drawing.Point(375, 136);
            this.checkBox_I01.Name = "checkBox_I01";
            this.checkBox_I01.Size = new System.Drawing.Size(263, 29);
            this.checkBox_I01.TabIndex = 6;
            this.checkBox_I01.Text = "ДАТЧИК ТЕМПЕРАТУРИ";
            this.checkBox_I01.UseVisualStyleBackColor = true;
            this.checkBox_I01.CheckedChanged += new System.EventHandler(this.checkBox_I01_CheckedChanged);
            // 
            // checkBox_I02
            // 
            this.checkBox_I02.AutoSize = true;
            this.checkBox_I02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_I02.Location = new System.Drawing.Point(375, 184);
            this.checkBox_I02.Name = "checkBox_I02";
            this.checkBox_I02.Size = new System.Drawing.Size(295, 29);
            this.checkBox_I02.TabIndex = 7;
            this.checkBox_I02.Text = "ДАТЧИК ВИТРАТИ ПАЛИВА";
            this.checkBox_I02.UseVisualStyleBackColor = true;
            this.checkBox_I02.CheckedChanged += new System.EventHandler(this.checkBox_I02_CheckedChanged);
            // 
            // label_Q00
            // 
            this.label_Q00.AutoSize = true;
            this.label_Q00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Q00.ForeColor = System.Drawing.Color.Red;
            this.label_Q00.Location = new System.Drawing.Point(25, 25);
            this.label_Q00.Name = "label_Q00";
            this.label_Q00.Size = new System.Drawing.Size(287, 25);
            this.label_Q00.TabIndex = 8;
            this.label_Q00.Text = "СИГНАЛІЗАЦІЯ ВИМКНЕНА";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Status.Location = new System.Drawing.Point(374, 289);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(151, 20);
            this.label_Status.TabIndex = 9;
            this.label_Status.Text = "ВІДКЛЮЧЕННЯ";
            // 
            // timer_Read_Output
            // 
            this.timer_Read_Output.Enabled = true;
            this.timer_Read_Output.Tick += new System.EventHandler(this.timer_Read_Output_Tick);
            // 
            // checkBox_I03
            // 
            this.checkBox_I03.AutoSize = true;
            this.checkBox_I03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_I03.Location = new System.Drawing.Point(378, 24);
            this.checkBox_I03.Name = "checkBox_I03";
            this.checkBox_I03.Size = new System.Drawing.Size(293, 29);
            this.checkBox_I03.TabIndex = 11;
            this.checkBox_I03.Text = "ВИМКНУТИ СИГНАЛІЗАЦІЮ";
            this.checkBox_I03.UseVisualStyleBackColor = true;
            this.checkBox_I03.CheckedChanged += new System.EventHandler(this.checkBox_I03_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 334);
            this.Controls.Add(this.checkBox_I03);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Q00);
            this.Controls.Add(this.checkBox_I02);
            this.Controls.Add(this.checkBox_I01);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.checkBox_I00);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ПЕЧЬ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_I00;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.CheckBox checkBox_I01;
        private System.Windows.Forms.CheckBox checkBox_I02;
        private System.Windows.Forms.Label label_Q00;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Timer timer_Read_Output;
        private System.Windows.Forms.CheckBox checkBox_I03;
    }
}

