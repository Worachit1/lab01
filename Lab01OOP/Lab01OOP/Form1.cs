namespace Lab01OOP
{
    public partial class Form1 : Form
    {
        // class variable
        double input1, result = 0;
        double input2;
        string operation = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        // ปุ่ม =
        private void numsum_Click(object sender, EventArgs e)
        {
            input2 = Double.Parse(this.Input.Text);
            this.Input.Text = result.ToString("#,##0.#####");
            this.process.Text = input1 + operation + input2 + " =";

            if (this.operation == "+")
            {
                result = input1 + input2;
                this.Input.Text =result.ToString("#,##0.#####");

            }
            else if(this.operation == "/")
            {
                result = input1 / input2;
                this.Input.Text =result.ToString("#,##0.#####");

            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
                this.Input.Text =result.ToString("#,##0.#####");

            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
                this.Input.Text =result.ToString("#,##0.#####");

            }
            this.Input.Text = result.ToString("#,##0.#####");

        }
        // ปุ่ม+
            private void numpush_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.operation = "+";
            this.process.Text = this.process.Text + "+";

        }
        // ปุ่ม /
        private void numdivision_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.operation = "/";
            this.process.Text = this.process.Text + "/";

        }
        // ปุ่ม *
        private void nummultiply_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.operation = "*";
            this.process.Text = this.process.Text + "*";

        }
        // ปุ่ม -
        private void numminus_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.Input.Text);
            this.Input.Text = "";
            this.operation = "-";
            this.process.Text = this.process.Text + "-";

        }
        // ปุ่ม 0
        private void numzero_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "0";
            this.process.Text = this.process.Text + "0";

        }
        // ปุ่ม 1
        private void numone_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "1";
            this.process.Text = this.process.Text + "1";

        }
        // ปุ่ม 2
        private void numtwo_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "2";
            this.process.Text = this.process.Text + "2";



        }
        // ปุ่ม 3
        private void numthree_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "3";
            this.process.Text = this.process.Text + "3";


        }
        // ปุ่ม 4
        private void numfour_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "4";
            this.process.Text = this.process.Text + "4";


        }
        // ปุ่ม 5
        private void numfive_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "5";
            this.process.Text = this.process.Text + "5";


        }
        // ปุ่ม 6
        private void numsix_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "6";
            this.process.Text = this.process.Text + "6";


        }
        // ปุ่ม 7
        private void numseven_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "7";
            this.process.Text = this.process.Text + "7";


        }
        // ปุ่ม 8
        private void numeight_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "8";
            this.process.Text = this.process.Text + "8";


        }
        // ปุ่ม 9
        private void numnine_Click(object sender, EventArgs e)
        {

            this.Input.Text = this.Input.Text + "9";
            this.process.Text = this.process.Text + "9";


        }

        // ปุ่ม delete
        private void delete_Click(object sender, EventArgs e)
        {
           this.Input.Text = "";
            this.process.Text = "";
        }

        // ปุ่ม .
        private void point_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + ".";
            this.process.Text = this.process.Text + ".";

        }
    }
}