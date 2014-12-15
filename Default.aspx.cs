using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public void result()  //求和算法//
    { 
        string symbol = (string)Session["symbol"];
       switch(symbol)
       {case "+":
           TextBox1.Text = Convert.ToString(Convert.ToInt32(Session["text1"]) + Convert.ToInt32(TextBox1.Text));
        Session["symbol"] = "";
        Session["text1"] = TextBox1.Text;

        break;
       case "-":
        TextBox1.Text = Convert.ToString(Convert.ToInt32(Session["text1"]) - Convert.ToInt32(TextBox1.Text));
        Session["symbol"] = "";
        Session["text1"] = TextBox1.Text;
        break;
       case "*":
        TextBox1.Text = Convert.ToString(Convert.ToInt32(Session["text1"]) * Convert.ToInt32(TextBox1.Text));
        Session["symbol"] = "";
        Session["text1"] = TextBox1.Text;
        break;
       case "/":
               if (Session["text1"]=="0")
                   TextBox1.Text = "除数不能为零！";
        TextBox1.Text = Convert.ToString(Convert.ToInt32(Session["text1"]) / Convert.ToInt32(TextBox1.Text));
        Session["symbol"] = "";
        Session["text1"] = TextBox1.Text;
        break;
    }
    }
    protected void Butsum_Click(object sender, EventArgs e) //求和//
    {
        result();        
    }
   
    protected void ButPlus_Click(object sender, EventArgs e)//加法//
    {
        
        if (Session["symbol"] != "+" & Session["symbol"] != "-" & Session["symbol"] != "*" & Session["symbol"] != "/")
               {
                Session["symbol"] = "+";            
            Session["text1"] = TextBox1.Text;
            TextBox1.Text = "";
            
        }
        else
        {
            result();
            Session["symbol"] = "+";
            TextBox1.Text = "";

        }
    }
    protected void ButMinus_Click(object sender, EventArgs e)  //减法//
    {
        if (Session["symbol"] != "+" & Session["symbol"] != "-" & Session["symbol"] != "*" & Session["symbol"] != "/")
        {
            Session["symbol"] = "-";
            Session["text1"] = TextBox1.Text;
            TextBox1.Text = "";

        }
        else
        {
            result();
            Session["symbol"] = "-";
            TextBox1.Text = "";

        }
    }
    protected void ButMulti_Click(object sender, EventArgs e)//乘法//
    {
        if (Session["symbol"] != "+" & Session["symbol"] != "-" & Session["symbol"] != "*" & Session["symbol"] != "/")
        {
            Session["symbol"] = "*";
            Session["text1"] = TextBox1.Text;
            TextBox1.Text = "";

        }
        else
        {
            result();
            Session["symbol"] = "*";
            TextBox1.Text = "";
        }
    }
    protected void ButDivide_Click(object sender, EventArgs e)//除法//
    {
        if (Session["symbol"] != "+" & Session["symbol"] != "-" & Session["symbol"] != "*" & Session["symbol"] != "/")
        {
            Session["symbol"] = "/";
            Session["text1"] = TextBox1.Text;
            TextBox1.Text = "";

        }
        else
        {
            result();
            Session["symbol"] = "/";
            TextBox1.Text = "";

        }
    }
   
    protected void Butclear_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        Session["text1"] = "";
        Session["text2"] = "";
        Session["symbol"] = "";
       
    }
    protected void But0_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "0";
    }
    protected void But1_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "1";

    }

    protected void But2_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "2";
    }
    protected void But3_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "3";
    }
    protected void But4_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "4";
    }
    protected void But5_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "5";
    }
    protected void But6_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "6";
    }
    protected void But7_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "7";
    }
    protected void But8_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "8";
    }
    protected void But9_Click(object sender, EventArgs e)
    {
        TextBox1.Text += "9";
    }
 
}
