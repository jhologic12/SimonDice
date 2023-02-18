namespace SimonDice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.lblNombrePuntaje = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(36, 39);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(667, 69);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Location = new System.Drawing.Point(378, 124);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(325, 239);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gold;
            this.btn0.Location = new System.Drawing.Point(47, 124);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(325, 239);
            this.btn0.TabIndex = 2;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(47, 380);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(325, 239);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(378, 380);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(325, 239);
            this.btn3.TabIndex = 4;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // timerDisplay
            // 
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // lblNombrePuntaje
            // 
            this.lblNombrePuntaje.AutoSize = true;
            this.lblNombrePuntaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePuntaje.Location = new System.Drawing.Point(308, 653);
            this.lblNombrePuntaje.Name = "lblNombrePuntaje";
            this.lblNombrePuntaje.Size = new System.Drawing.Size(85, 25);
            this.lblNombrePuntaje.TabIndex = 5;
            this.lblNombrePuntaje.Text = "Puntaje:";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.SystemColors.Control;
            this.lblPuntaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuntaje.Location = new System.Drawing.Point(396, 654);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(22, 25);
            this.lblPuntaje.TabIndex = 6;
            this.lblPuntaje.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 733);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblNombrePuntaje);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Simon Da Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIniciar;
        private Button btn1;
        private Button btn0;
        private Button btn2;
        private Button btn3;
        private System.Windows.Forms.Timer timerDisplay;
        private Label lblNombrePuntaje;
        private Label lblPuntaje;
    }
}