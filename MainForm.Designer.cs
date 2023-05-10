namespace GeradorQrCodes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LblUrlRede = new Label();
            TxtUrlRede = new TextBox();
            BtnGerarQrCode = new Button();
            SuspendLayout();
            // 
            // LblUrlRede
            // 
            LblUrlRede.AutoSize = true;
            LblUrlRede.BackColor = Color.Transparent;
            LblUrlRede.Font = new Font("Cambria Math", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblUrlRede.Location = new Point(-3, 67);
            LblUrlRede.Name = "LblUrlRede";
            LblUrlRede.Size = new Size(77, 89);
            LblUrlRede.TabIndex = 0;
            LblUrlRede.Text = "Link:";
            // 
            // TxtUrlRede
            // 
            TxtUrlRede.Location = new Point(58, 102);
            TxtUrlRede.Name = "TxtUrlRede";
            TxtUrlRede.Size = new Size(381, 23);
            TxtUrlRede.TabIndex = 1;
            // 
            // BtnGerarQrCode
            // 
            BtnGerarQrCode.FlatStyle = FlatStyle.System;
            BtnGerarQrCode.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGerarQrCode.Location = new Point(157, 218);
            BtnGerarQrCode.Name = "BtnGerarQrCode";
            BtnGerarQrCode.Size = new Size(153, 45);
            BtnGerarQrCode.TabIndex = 2;
            BtnGerarQrCode.Text = "Gerar";
            BtnGerarQrCode.UseVisualStyleBackColor = true;
            BtnGerarQrCode.Click += BtnGerarQrCode_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(451, 423);
            Controls.Add(BtnGerarQrCode);
            Controls.Add(TxtUrlRede);
            Controls.Add(LblUrlRede);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Gerador de Qr Code";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUrlRede;
        private TextBox TxtUrlRede;
        private Button BtnGerarQrCode;
    }
}