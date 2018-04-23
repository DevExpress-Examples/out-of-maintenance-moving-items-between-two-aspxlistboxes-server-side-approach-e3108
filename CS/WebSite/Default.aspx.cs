using System;
using DevExpress.Web.ASPxEditors;
public partial class _Default : System.Web.UI.Page {
    protected void bntMoveOne_Click(object sender, EventArgs e) {
        if (lbOptions.SelectedItems.Count > 0)
            moveItems(lbSelectedOptions, lbOptions);
    }
    protected void bntReturnOne_Click(object sender, EventArgs e) {
        if (lbSelectedOptions.SelectedItems.Count > 0)
            moveItems(lbOptions, lbSelectedOptions);
    }
    protected void btnMoveAll_Click(object sender, EventArgs e) {
        lbOptions.SelectAll();
        moveItems(lbSelectedOptions, lbOptions);
    }
    protected void btnReturnAll_Click(object sender, EventArgs e) {
        lbSelectedOptions.SelectAll();
        moveItems(lbOptions, lbSelectedOptions);
    }
    private void moveItems(ASPxListBox targetlistBox, ASPxListBox sourcelistBox) {
        for (int i = 0; i < sourcelistBox.SelectedItems.Count; i++) {
            targetlistBox.Items.Add(sourcelistBox.SelectedItems[i]);
        }
        targetlistBox.UnselectAll();
        sourcelistBox.UnselectAll();
    }

}
