﻿namespace Lab2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.btnSetBaseLocomotive = new System.Windows.Forms.Button();
            this.btnSetPlatzLocomotive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(245, 366);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(97, 26);
            this.buttonSelectColor.TabIndex = 1;
            this.buttonSelectColor.Text = "Выбрать цвет";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(352, 366);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(128, 27);
            this.buttonSelectDopColor.TabIndex = 2;
            this.buttonSelectDopColor.Text = "Выбрать доп цвет";
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(92, 320);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(80, 20);
            this.textBoxMaxSpeed.TabIndex = 3;
            // 
            // textBoxMaxCountPassenger
            // 
            this.textBoxMaxCountPassenger.Location = new System.Drawing.Point(92, 351);
            this.textBoxMaxCountPassenger.Name = "textBoxMaxCountPassenger";
            this.textBoxMaxCountPassenger.Size = new System.Drawing.Size(80, 20);
            this.textBoxMaxCountPassenger.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MaxSpeed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MaxPass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(92, 377);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(80, 20);
            this.textBoxWeight.TabIndex = 8;
            // 
            // btnSetBaseLocomotive
            // 
            this.btnSetBaseLocomotive.Location = new System.Drawing.Point(245, 409);
            this.btnSetBaseLocomotive.Name = "btnSetBaseLocomotive";
            this.btnSetBaseLocomotive.Size = new System.Drawing.Size(163, 23);
            this.btnSetBaseLocomotive.TabIndex = 9;
            this.btnSetBaseLocomotive.Text = "Задать локомотив";
            this.btnSetBaseLocomotive.UseVisualStyleBackColor = true;
            this.btnSetBaseLocomotive.Click += new System.EventHandler(this.btnSetBaseLocomotive_Click);
            // 
            // btnSetPlatzLocomotive
            // 
            this.btnSetPlatzLocomotive.Location = new System.Drawing.Point(414, 410);
            this.btnSetPlatzLocomotive.Name = "btnSetPlatzLocomotive";
            this.btnSetPlatzLocomotive.Size = new System.Drawing.Size(187, 22);
            this.btnSetPlatzLocomotive.TabIndex = 10;
            this.btnSetPlatzLocomotive.Text = "Задать тепловоз";
            this.btnSetPlatzLocomotive.UseVisualStyleBackColor = true;
            this.btnSetPlatzLocomotive.Click += new System.EventHandler(this.btnSetPlatzLocomotive_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Движение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Труба";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(352, 320);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Уголь";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 459);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSetPlatzLocomotive);
            this.Controls.Add(this.btnSetBaseLocomotive);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxCountPassenger);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button btnSetBaseLocomotive;
        private System.Windows.Forms.Button btnSetPlatzLocomotive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

