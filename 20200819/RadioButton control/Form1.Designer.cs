﻿namespace RadioButton_control
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbJapan = new System.Windows.Forms.RadioButton();
            this.rbChina = new System.Windows.Forms.RadioButton();
            this.rbKorea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOthers);
            this.groupBox1.Controls.Add(this.rbJapan);
            this.groupBox1.Controls.Add(this.rbChina);
            this.groupBox1.Controls.Add(this.rbKorea);
            this.groupBox1.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(47, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbOthers.Location = new System.Drawing.Point(39, 241);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(119, 28);
            this.rbOthers.TabIndex = 0;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "그 외 국가";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbJapan
            // 
            this.rbJapan.AutoSize = true;
            this.rbJapan.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbJapan.Location = new System.Drawing.Point(39, 180);
            this.rbJapan.Name = "rbJapan";
            this.rbJapan.Size = new System.Drawing.Size(69, 28);
            this.rbJapan.TabIndex = 0;
            this.rbJapan.TabStop = true;
            this.rbJapan.Text = "일본";
            this.rbJapan.UseVisualStyleBackColor = true;
            // 
            // rbChina
            // 
            this.rbChina.AutoSize = true;
            this.rbChina.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbChina.Location = new System.Drawing.Point(39, 119);
            this.rbChina.Name = "rbChina";
            this.rbChina.Size = new System.Drawing.Size(69, 28);
            this.rbChina.TabIndex = 0;
            this.rbChina.TabStop = true;
            this.rbChina.Text = "중국";
            this.rbChina.UseVisualStyleBackColor = true;
            // 
            // rbKorea
            // 
            this.rbKorea.AutoSize = true;
            this.rbKorea.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbKorea.Location = new System.Drawing.Point(39, 58);
            this.rbKorea.Name = "rbKorea";
            this.rbKorea.Size = new System.Drawing.Size(107, 28);
            this.rbKorea.TabIndex = 0;
            this.rbKorea.TabStop = true;
            this.rbKorea.Text = "대한민국";
            this.rbKorea.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(456, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbFemale.Location = new System.Drawing.Point(134, 35);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 28);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "여";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbMale.Location = new System.Drawing.Point(44, 35);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 28);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "남";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(500, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioButton Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbJapan;
        private System.Windows.Forms.RadioButton rbChina;
        private System.Windows.Forms.RadioButton rbKorea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button button1;
    }
}

