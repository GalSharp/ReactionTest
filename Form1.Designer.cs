
namespace ReactionTest
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Red;
            this.pictureBox.Location = new System.Drawing.Point(409, 116);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(309, 271);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(367, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(404, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Нажмите как только будет зеленый";
            // 
            // timerClick
            // 
            this.timerClick.Interval = 1;
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(477, 429);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(187, 61);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "РЕСТАРТ";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1107, 561);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Reaction Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.Button buttonRestart;
    }
}

