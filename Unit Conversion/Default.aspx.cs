using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page
{

    protected String[] names = { "Kilometers", "Meters", "Centimeters", "Millimeters", "Miles", "Yards", "Feet", "Inches" };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dList1.DataSource = names;
            dList1.DataBind();
            dList2.DataSource = names;
            dList2.DataBind();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        Label1.Text = "";
        if (valid(TextBox1.Text) != true)
        {
            Label1.Text = "Error! Invalid Input! Valid value is NATURAL number!";
        }
        else
        {
            double tmp1 = Convert.ToDouble(TextBox1.Text);
            if (tmp1 < 0)
            {
                Label1.Text = "Error! Invalid Input! Valid value is a positive number!";
                return;

            }
            double[] ConvertParameter = { 0.001, 1, 100, 1000, 0.0006124, 1.0936133, 3.2808399, 39.3700787 };
            double tmp2 = tmp1 / ConvertParameter[dList1.SelectedIndex];
            double res = tmp2 * ConvertParameter[dList2.SelectedIndex];
            TextBox2.Text = double.Parse(res.ToString()).ToString("0.##########");
        }

    }

    public static bool valid(String input)
    {
        return (input != string.Empty && !Regex.IsMatch(input, "[^0-9]$")) ? true : false;
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

}