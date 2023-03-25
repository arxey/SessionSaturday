namespace MegaDriveMordovskiy
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PictureCar = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSign = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelTop.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.PanelTop.Controls.Add(this.LabelName);
            this.PanelTop.Controls.Add(this.PictureCar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(530, 100);
            this.PanelTop.TabIndex = 0;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.PanelBottom.Controls.Add(this.ButtonSign);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 350);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(530, 100);
            this.PanelBottom.TabIndex = 1;
            // 
            // PictureCar
            // 
            this.PictureCar.Image = ((System.Drawing.Image)(resources.GetObject("PictureCar.Image")));
            this.PictureCar.Location = new System.Drawing.Point(12, 3);
            this.PictureCar.Name = "PictureCar";
            this.PictureCar.Size = new System.Drawing.Size(100, 94);
            this.PictureCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCar.TabIndex = 0;
            this.PictureCar.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(190, 36);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(159, 35);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Компания \"Мегадрайв\"";
            // 
            // ButtonSign
            // 
            this.ButtonSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.ButtonSign.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSign.Location = new System.Drawing.Point(196, 32);
            this.ButtonSign.Name = "ButtonSign";
            this.ButtonSign.Size = new System.Drawing.Size(115, 44);
            this.ButtonSign.TabIndex = 0;
            this.ButtonSign.Text = "Войти";
            this.ButtonSign.UseVisualStyleBackColor = false;
            this.ButtonSign.Click += new System.EventHandler(this.ButtonSign_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(111, 157);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(106, 35);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Введите логин";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(104, 219);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(113, 35);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Введите пароль";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLogin.Location = new System.Drawing.Point(223, 154);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(100, 40);
            this.TextBoxLogin.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(223, 219);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 40);
            this.TextBoxPassword.TabIndex = 5;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sign_FormClosing);
            this.Load += new System.EventHandler(this.Sign_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox PictureCar;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonSign;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}

