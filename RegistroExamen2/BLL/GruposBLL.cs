using RegistroExamen2.DAL;
using RegistroExamen2.Entidades;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroExamen2.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos grupos) // guardar
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static bool Modificar(Grupos grupos) // modificar
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(grupos).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int GId) // eliminar
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Grupos grupos = contexto.Grupos.Find(GId);

                contexto.Grupos.Remove(grupos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Grupos Buscar(int GId)
        {
            Grupos grupos = new Grupos();
            Contexto contexto = new Contexto();

            try
            {
                contexto.Grupos.Find(GId);
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return grupos;
        }

        public static List<Grupos> GetList(Expression<Func<Grupos, bool>> expression)
        {
            List<Grupos> grupos = new List<Grupos>();
            Contexto contexto = new Contexto();
            try
            {
                grupos = contexto.Grupos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return grupos;
        }

    }

}

