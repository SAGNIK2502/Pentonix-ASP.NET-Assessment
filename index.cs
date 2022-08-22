private void btnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1=Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            sum = num1 + num2;
            lblResult.Text = sum.ToString();
        }
        string message = "Simple MessageBox";  
string title = "Title";  
MessageBox.Show(message, title);
string message = "Do you want to close this window?";  
string title = "Close Window";  
MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
DialogResult result = MessageBox.Show(message, title, buttons);  
if (result == DialogResult.Yes) {  
    this.Close();  
} else {  

}
string message = "Do you want to abort this operation?";  
string title = "Close Window";  
MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;  
DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);  
if (result == DialogResult.Abort) {  
    this.Close();  
}  
elseif(result == DialogResult.Retry) {  
   
}  
else {  
    
}
tring message = "Do you want to abort this operation?";  
string title = "Close Window";  
MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;  
DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);  
if (result == DialogResult.Abort) {  
    this.Close();  
}  
elseif(result == DialogResult.Retry) {  
     
}  
else {  

}
private void button1_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);
            int area = width * length;
            int perimeter = (width + length) * 2;
            lblPerimeter.Text = "Perimeter : " + perimeter;
            lblArea.Text = "Area : " + area;
        }