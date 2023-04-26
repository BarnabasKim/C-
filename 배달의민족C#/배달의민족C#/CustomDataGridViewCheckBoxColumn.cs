using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using 배달의민족C_;


namespace 배달의민족C_
{
    public class CustomDataGridViewCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public CustomDataGridViewCheckBoxColumn() : base() =>
            CellTemplate = new CustomDataGridViewCheckBoxCell();

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(CustomDataGridViewCheckBoxCell)))
                    throw new InvalidCastException("CustomDataGridViewCheckBoxCell.");

                base.CellTemplate = value;
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Size), "17, 17")]
        [Description("The size of the check box.")]
        public Size CheckBoxSize { get; set; } = new Size(17, 17);

        // We should copy the new properties.
        public override object Clone()
        {
            var c = base.Clone() as CustomDataGridViewCheckBoxColumn;
            c.CheckBoxSize = CheckBoxSize;
            return c;
        }
    }

}