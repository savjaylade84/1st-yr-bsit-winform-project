using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *  <p>
 * 
 *      this class contains methods to help clear more fields in the form 
 *      without clearing it one by one. its help to clear more fields at the same time.
 * 
 *  </p>
 * 
 *  @author john jayson b. de leon
 *  Date Modify: 24/03/2019
 * 
 */

namespace InfoForm
{

    public class Cleaner : InterfaceCleaner
    {
        private TextBox[] txtbox;
        private RichTextBox[] richtxtbox;
        private ListBox[] listBox;
        private ComboBox[] comboBox;
        private Boolean IsAllEmpty;

        //set nothing
        public Cleaner() { }

        //destroy the object of this class
        ~Cleaner() {

            txtbox = null;
            richtxtbox = null;
            listBox = null;
            comboBox = null;

        }

        public void ClearAll() {

            if (txtbox != null) { this.ClearTextboxes(); }
            if (richtxtbox != null) { this.ClearRichTextBoxes(); } 
            if (listBox != null) { this.ClearListBoxes(); } 
            if (comboBox != null) { this.ClearComboBoxes(); }

        }

        //check if textbox is empty
        public Boolean isTxtBoxEmpty
        {
            get
            {
                if (txtbox != null)
                {
                    foreach (TextBox a in txtbox)
                    {

                        if (a.Text != "")
                            return false;

                    }

                } 

                    return true;

            }
        }

        //check if rich textbox is empty
        public Boolean isRichTxtBoxEmpty
        {
            get
            {
                if (richtxtbox != null)
                {

                    foreach (RichTextBox b in richtxtbox)
                    {

                        if (b.Text != "")
                            return false;

                    }

                }

                return true;

            }
        }

        //check if listbox is empty
        public Boolean isListBoxEmpty
        {
            get
            {
                if (listBox != null)
                {

                    foreach (ListBox c in listBox)
                    {

                        if (c.Text != "")
                            return false;

                    }

                }

                return true;

            }
        }

        //check if combobox is empty
        public Boolean isComboBoxEmpty
        {
            get
            {
                if (comboBox != null)
                {

                    foreach (ComboBox d in comboBox)
                    {

                        if (d.Text != "")
                            return false;

                    }

                }

                return true;

            }
        }

        //check if all are empty
        public Boolean isAllEmpty{
            set {

                IsAllEmpty = isTxtBoxEmpty && isRichTxtBoxEmpty && isListBoxEmpty && isComboBoxEmpty;

            }
            get {

                if (IsAllEmpty) { return true; }
                
                    return false;

            }


        }

        //check if some are empty
        public Boolean isSomeEmpty
        {
            set
            {

                IsAllEmpty = isTxtBoxEmpty || isRichTxtBoxEmpty || isListBoxEmpty || isComboBoxEmpty;

            }
            get
            {

                if (IsAllEmpty) { return true; }

                return false;

            }


        }

        //set the value of textbox 
        public TextBox[] Textboxes {

            set {

               this.txtbox = value;

            }

        }

        //set the value of  rich text box
        public RichTextBox[] RichTextBoxes {

            set {

                this.richtxtbox = value;

            }

        }

        //set the value of list box
        public ListBox[] ListBoxes {

            set {

                this.listBox = value;

            }

        }

        //set the value of comboboxes
        public ComboBox[] ComboBoxes {

            set {

                this.comboBox = value;

            }

        }

        //clear all textbox
        public void ClearTextboxes() {

            foreach (TextBox b in this.txtbox)
                b.Clear();

        }

        //clear all rich text box
        public void ClearRichTextBoxes() {

            foreach (RichTextBox b in this.richtxtbox)
                b.Clear();

        }

        //clear all combobox
        public void ClearComboBoxes(){

            foreach (ComboBox b in this.comboBox)
                b.Items.Clear();

        }

        //clear all listbox
        public void ClearListBoxes(){


            foreach (ListBox b in this.listBox)
                b.Items.Clear();

        }

    }
}
