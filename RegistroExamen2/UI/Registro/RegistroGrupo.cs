using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen2.Entidades;

namespace RegistroExamen2.UI.Registro
{
    public partial class RegistroGrupo : Form
    {
        public RegistroGrupo()
        {
            InitializeComponent();
        }

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();
            grupo.Fecha = fechaDateTime.Value;
            grupo.GrupoId = Convert.ToInt32(GrupoIdUpDown.Value);
            grupo.Descripcion = descripcionTextBox.Text;
            grupo.Cantidad = Convert.ToInt32(CantidadUpDown.Value);
            grupo.CantGrupos = Convert.ToInt32(GruposDUpDown.Value);
            grupo.Integrantes = Convert.ToInt32(IntegrantesUpDown.Value);

            return grupo;
        }

        private void ClearAll()
        {
            GrupoIdUpDown.Value = 0;
            descripcionTextBox.Clear();
            CantidadUpDown.Value = 0;
            GruposDUpDown.Value = 0;
        }

        private bool Validar(int validar) // VALIDAR
        {
            bool paso = false;
            if (validar == 1 && GrupoIdUpDown.Value == 0)
            {
                ErrorProvider.SetError(GrupoIdUpDown, "Ingrese el ID del Grupo");
                paso = true;
            }
            if (validar == 2 && descripcionTextBox.Text == String.Empty)
            {
                ErrorProvider.SetError(descripcionTextBox, "Ingrese una Descripcion");
                paso = true;
            }
            if (validar == 2 && CantidadUpDown.Value == 0)
            {
                ErrorProvider.SetError(CantidadUpDown, "Ingrese la cantidad de estudiantes ");
                paso = true;
            }
            if (validar == 2 && GruposDUpDown.Value == 0)
            {
                ErrorProvider.SetError(GruposDUpDown, "Ingrese Numero de Grupo");
                paso = true;
            }
            return paso;

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
            ErrorProvider.Clear();
        }

        private void btn_Buscar_Click(object sender, EventArgs e) // BOTON BUSCAR
        {
            ErrorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese el ID del Grupo");
                return;
            }

            int id = Convert.ToInt32(GrupoIdUpDown.Value);
            Grupos grupo = BLL.GruposBLL.Buscar(id);

            if (grupo != null)
            {
                GrupoIdUpDown.Value = grupo.GrupoId;
                descripcionTextBox.Text = grupo.Descripcion;
                CantidadUpDown.Value = grupo.Cantidad;
                GruposDUpDown.Value = grupo.CantGrupos;
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingresar un ID");
                return;
            }

            int id = Convert.ToInt32(GrupoIdUpDown.Value);

            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearAll();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            ErrorProvider.Clear();

            if (GrupoIdUpDown.Value == 0)
            {
                if (BLL.GruposBLL.Guardar(LlenaClase()))
                {
                    MessageBox.Show("Guardado!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
            }
            else
            {
                if (BLL.GruposBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Guardado!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
