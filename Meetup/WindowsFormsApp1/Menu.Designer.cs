
namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Org2 = new System.Windows.Forms.Button();
            this.Adm1 = new System.Windows.Forms.Button();
            this.User1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Adm2 = new System.Windows.Forms.Button();
            this.Org1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Org2
            // 
            this.Org2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Org2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Org2.Location = new System.Drawing.Point(463, 385);
            this.Org2.Name = "Org2";
            this.Org2.Size = new System.Drawing.Size(142, 53);
            this.Org2.TabIndex = 0;
            this.Org2.Text = "Подтверждение пользователей";
            this.Org2.UseVisualStyleBackColor = false;
            this.Org2.Visible = false;
            this.Org2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adm1
            // 
            this.Adm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adm1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adm1.Location = new System.Drawing.Point(463, 88);
            this.Adm1.Name = "Adm1";
            this.Adm1.Size = new System.Drawing.Size(142, 53);
            this.Adm1.TabIndex = 3;
            this.Adm1.Text = "Редактирование пользователей";
            this.Adm1.UseVisualStyleBackColor = false;
            this.Adm1.Visible = false;
            this.Adm1.Click += new System.EventHandler(this.button2_Click);
            // 
            // User1
            // 
            this.User1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User1.Location = new System.Drawing.Point(12, 385);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(126, 53);
            this.User1.TabIndex = 8;
            this.User1.Text = "Просмотр конференций";
            this.User1.UseVisualStyleBackColor = false;
            this.User1.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Добро пожаловать.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Данная программа создана для просмотра информации о предстоящих конференциях.\r\nДл" +
    "я просмотра списка конференций нажмите на кнопку \"Просмотр конференций\"\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Adm2
            // 
            this.Adm2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adm2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adm2.Location = new System.Drawing.Point(463, 147);
            this.Adm2.Name = "Adm2";
            this.Adm2.Size = new System.Drawing.Size(142, 49);
            this.Adm2.TabIndex = 13;
            this.Adm2.Text = "Конференции";
            this.Adm2.UseVisualStyleBackColor = false;
            this.Adm2.Visible = false;
            this.Adm2.Click += new System.EventHandler(this.button4_Click);
            // 
            // Org1
            // 
            this.Org1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Org1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Org1.Location = new System.Drawing.Point(463, 326);
            this.Org1.Name = "Org1";
            this.Org1.Size = new System.Drawing.Size(142, 53);
            this.Org1.TabIndex = 14;
            this.Org1.Text = "Редактирование конференций";
            this.Org1.UseVisualStyleBackColor = false;
            this.Org1.Visible = false;
            this.Org1.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Запись на конференцию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Org1);
            this.Controls.Add(this.Adm2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User1);
            this.Controls.Add(this.Adm1);
            this.Controls.Add(this.Org2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Научные конференции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Org2;
        private System.Windows.Forms.Button Adm1;
        private System.Windows.Forms.Button User1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adm2;
        private System.Windows.Forms.Button Org1;
        private System.Windows.Forms.Button button1;
    }
}