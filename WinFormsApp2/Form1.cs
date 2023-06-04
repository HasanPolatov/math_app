using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using System;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        TableLayoutPanel tableLayoutPanel = new();
        List<MyClass> list = new();
        DataGridView dataGridView = new DataGridView();
        DataGridView deltas = new DataGridView();
        List<PointF> liniarFunctionPoints = new List<PointF>();
        List<PointF> squareFunctionPoints = new List<PointF>();

        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;

            tableLayoutPanel.Controls.Clear();

            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Location = new Point(label1.Location.X, label1.Location.Y + 50);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = n + 1;

            Label labelX = new();
            Label labelY = new();

            labelX.Text = "x";
            labelY.Text = "y";
            tableLayoutPanel.Controls.Add(labelX);
            tableLayoutPanel.Controls.Add(labelY);

            for (int i = 1; i < n + 1; i++)
            {
                TextBox textBoxX = new();
                TextBox textBoxY = new();
                textBoxX.TextChanged += TextBox_TextChanged;
                textBoxY.TextChanged += TextBox_TextChanged;
                tableLayoutPanel.Controls.Add(textBoxX);
                tableLayoutPanel.Controls.Add(textBoxY);
            }

            button1.Visible = false;
            //button2.Visible = true;

            this.Controls.Add(tableLayoutPanel);
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            bool allFilled = true;
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    allFilled = false;
                    break;
                }
            }
            button2.Visible = allFilled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MyClass sumS = new MyClass(0, 0, 0, 0, 0, 0, 0);

            int index = 0;

            dataGridView.AutoSize = true;

            tableLayoutPanel.Visible = false;

            dataGridView.Visible = true;

            dataGridView.Location = new Point(label1.Location.X, label1.Location.Y + 50);

            dataGridView.ColumnCount = 8;

            dataGridView.Columns[0].Name = "t";
            dataGridView.Columns[1].Name = "x";
            dataGridView.Columns[2].Name = "y";
            dataGridView.Columns[3].Name = "x^2";
            dataGridView.Columns[4].Name = "x^3";
            dataGridView.Columns[5].Name = "x^4";
            dataGridView.Columns[6].Name = "x * y";
            dataGridView.Columns[7].Name = "x^2 * y";


            for (int i = 2; i < tableLayoutPanel.Controls.Count; i += 2)
            {

                MyClass myClass = new MyClass();

                if (i % 2 == 0)
                {


                    double x, y;
                    if (double.TryParse(tableLayoutPanel.Controls[i].Text, out x) && double.TryParse(tableLayoutPanel.Controls[i + 1].Text, out y))
                    {
                        myClass.X = x;
                        myClass.Y = y;
                        myClass.X2 = Math.Pow(x, 2);
                        myClass.X3 = Math.Pow(x, 3);
                        myClass.X4 = Math.Pow(x, 4);
                        myClass.XY = x * y;
                        myClass.X2Y = Math.Pow(x, 2) * y;
                        string[] row = new string[] {
                            index.ToString(),
                            myClass.X.ToString("0.####"),
                            myClass.Y.ToString("0.####"),
                            myClass.X2.ToString("0.####"),
                            myClass.X3.ToString("0.####"),
                            myClass.X4.ToString("0.####"),
                            myClass.XY.ToString("0.####"),
                            myClass.X2Y.ToString("0.####")
                        };

                        index++;

                        dataGridView.Rows.Add(row);
                    }
                }

                list.Add(myClass);
            }



            for (int i = 0; i < list.Count; i++)
            {
                sumS.X += list[i].X;
                sumS.Y += list[i].Y;
                sumS.X2 += list[i].X2;
                sumS.X3 += list[i].X3;
                sumS.X4 += list[i].X4;
                sumS.XY += list[i].XY;
                sumS.X2Y += list[i].X2Y;
            }

            string[] lastRow = new string[]
            {
                "sum",
                sumS.X.ToString("0.####"),
                sumS.Y.ToString("0.####"),
                sumS.X2.ToString("0.####"),
                sumS.X3.ToString("0.####"),
                sumS.X4.ToString("0.####"),
                sumS.XY.ToString("0.####"),
                sumS.X2Y.ToString("0.####"),
            };

            dataGridView.Rows.Add(lastRow);


            this.Controls.Add(dataGridView);
            PrintLabels(sumS);

        }

        public void PrintLabels(MyClass sumS)
        {
            double[,] valueOfLinearMethod = new double[,]
            {
                { sumS.X2, sumS.X, sumS.XY },
                { sumS.X, n, sumS.Y}
            };

            double[] responceOfLinearMethod = SolveLinearEquations(valueOfLinearMethod);


            string linearAns = "y = " + responceOfLinearMethod[0].ToString("0.####") + "x ";

            if (responceOfLinearMethod[1] != 0)
            {
                if (responceOfLinearMethod[1] > 0)
                {
                    linearAns += "+ ";
                }

                linearAns += responceOfLinearMethod[1].ToString("0.####");
            }



            label2.Text = "Chiziqli model : " + linearAns;
            label2.Visible = true;


            double[,] valueOfSquareMethod = new double[,]
            {
                { sumS.X4, sumS.X3, sumS.X2, sumS.X2Y },
                { sumS.X3, sumS.X2, sumS.X, sumS.XY },
                { sumS.X2, sumS.X, n, sumS.Y }
            };


            double[] responceOfSquareMethod = SolveLinearEquations(valueOfSquareMethod);

            string squareAns = "y = ";


            if (responceOfSquareMethod[0] != 0)
            {
                squareAns += responceOfSquareMethod[0].ToString("0.####") +
                "x" + '\u00B2' + " ";
            }


            if (responceOfSquareMethod[1] != 0)
            {

                if (responceOfSquareMethod[1] >= 0)
                {
                    squareAns += "+ ";
                }
                squareAns += responceOfSquareMethod[1].ToString("0.####") + "x ";
            }

            if (responceOfSquareMethod[2] != 0)
            {
                if (responceOfSquareMethod[2] > 0)
                {
                    squareAns += "+ ";
                }

                squareAns += responceOfSquareMethod[2].ToString("0.####");
            }



            label3.Text = "Kvadratik model : " + squareAns;
            label3.Visible = true;

            button2.Visible = false;


            PrintDeltas(responceOfLinearMethod, responceOfSquareMethod);

        }

        private void PrintDeltas(double[] y1, double[] y2)
        {

            deltas.Visible = true;

            deltas.Location = new Point(dataGridView.Location.X + dataGridView.Width + 20, dataGridView.Location.Y);

            deltas.AutoSize = true;

            deltas.ColumnCount = 4;

            deltas.Columns[0].Name = "y\u2081";
            deltas.Columns[1].Name = "y\u2082";
            deltas.Columns[2].Name = "\u0394y\u2081(x\u2081)";
            deltas.Columns[3].Name = "\u0394y\u2082(x\u2082)";

            for (int i = 0; i < list.Count; i++)
            {

                double y_1_x = list[i].X * y1[0] + y1[1];
                double y_2_x = Math.Pow(list[i].X, 2) * y2[0] + list[i].X * y2[1] + y2[2];
                liniarFunctionPoints.Add(new PointF((float)list[i].X, (float)(y_1_x)));
                squareFunctionPoints.Add(new PointF((float)list[i].X, (float)(y_2_x)));

                string[] row = new string[]
                {
                    y_1_x.ToString("0.####"),
                    y_2_x.ToString("0.####"),
                    Math.Abs(y_1_x - list[i].Y).ToString("0.####"),
                    Math.Abs(y_2_x - list[i].Y).ToString("0.####")
                };

                deltas.Rows.Add(row);
                this.Controls.Add(deltas);

            }

            label4.Visible = true;
            label5.Visible = true;
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

        }

        public static double[] SolveLinearEquations(double[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = i + 1; j < rowCount; j++)
                {
                    double ratio = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < colCount; k++)
                    {
                        matrix[j, k] -= ratio * matrix[i, k];
                    }
                }
            }

            double[] result = new double[rowCount];
            for (int i = rowCount - 1; i >= 0; i--)
            {
                result[i] = matrix[i, colCount - 1];
                for (int j = i + 1; j < colCount - 1; j++)
                {
                    result[i] -= matrix[i, j] * result[j];
                }
                result[i] /= matrix[i, i];
            }

            return result;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            dataGridView.Rows.Clear();
            tableLayoutPanel.Controls.Clear();
            deltas.Rows.Clear();
            dataGridView.Visible = false;
            deltas.Visible = false;
            numericUpDown1.Value = 2;
            label2.Visible = false;
            label3.Visible = false;
            tableLayoutPanel.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            liniarFunctionPoints.Clear();
            squareFunctionPoints.Clear();
            list.Clear();
            label4.Visible = false;
            label5.Visible = false;
        }


        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;
            int padding = 50;

            double xScale = (width - 2 * padding) / 20.0;
            double yScale = (height - 2 * padding) / 10.0;

            using (Pen pen = new Pen(Color.Blue))
            {
                g.DrawLine(pen, padding, padding, padding, height - padding);
                g.DrawLine(pen, padding, height - padding, width - padding, height - padding);

                pen.Color = Color.Black;
                pen.Width = 2;


                if (liniarFunctionPoints.Count > 1)
                {
                    for (int i = 1; i < liniarFunctionPoints.Count; i++)
                    {
                        PointF previousPoint = liniarFunctionPoints[i - 1];
                        PointF currentPoint = liniarFunctionPoints[i];

                        int previousScreenX = (int)(previousPoint.X * xScale + width / 2);
                        int previousScreenY = (int)((-1) * previousPoint.Y * yScale + height / 2);
                        int currentScreenX = (int)(currentPoint.X * xScale + width / 2);
                        int currentScreenY = (int)((-1) * currentPoint.Y * yScale + height / 2);

                        g.DrawLine(pen, previousScreenX, previousScreenY, currentScreenX, currentScreenY);
                    }
                }

            }
        }


        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;
            int padding = 50;

            double xScale = (width - 2 * padding) / 20.0;
            double yScale = (height - 2 * padding) / 10.0;

            using (Pen pen = new Pen(Color.Blue))
            {
                g.DrawLine(pen, padding, padding, padding, height - padding);
                g.DrawLine(pen, padding, height - padding, width - padding, height - padding);

                pen.Color = Color.Black;
                pen.Width = 2;

                if (squareFunctionPoints.Count > 1)
                {
                    for (int i = 1; i < squareFunctionPoints.Count; i++)
                    {
                        PointF previousPoint = squareFunctionPoints[i - 1];
                        PointF currentPoint = squareFunctionPoints[i];

                        int previousScreenX = (int)(previousPoint.X * xScale + width / 2);
                        int previousScreenY = (int)((-1) * previousPoint.Y * yScale + height / 2);
                        int currentScreenX = (int)(currentPoint.X * xScale + width / 2);
                        int currentScreenY = (int)((-1) * currentPoint.Y * yScale + height / 2);

                        g.DrawLine(pen, previousScreenX, previousScreenY, currentScreenX, currentScreenY);
                    }
                }
            }
        }


    }



    public class MyClass
    {
        private double x;
        private double y;
        private double x2;
        private double x3;
        private double x4;
        private double xy;
        private double x2y;

        public MyClass()
        {

        }

        public MyClass(double x, double y, double x2, double x3, double x4, double xy, double x2y)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.xy = xy;
            this.x2y = x2y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public double X3
        {
            get { return x3; }
            set { x3 = value; }
        }

        public double X4
        {
            get { return x4; }
            set { x4 = value; }
        }

        public double XY
        {
            get { return xy; }
            set { xy = value; }
        }

        public double X2Y
        {
            get { return x2y; }
            set { x2y = value; }
        }
    }



}