using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public class Botones
    {
        public void Boton(DataGridView dgv)
        {
            DataGridViewImageColumn imgEditar = new DataGridViewImageColumn();
            imgEditar.HeaderText = "EDITAR";
            imgEditar.Name = "EDITAR";
            imgEditar.Image = proyecto3.Properties.Resources._3592815_compose_create_edit_edit_file_office_pencil_writing_107734;
            imgEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv.Columns.Add(imgEditar);

            DataGridViewImageColumn imgEliminar = new DataGridViewImageColumn();
            imgEliminar.HeaderText = "ELIMINAR";
            imgEliminar.Name = "ELIMINAR";
            imgEliminar.Image = proyecto3.Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760;
            imgEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgv.Columns.Add(imgEliminar);
        }
    }
}
