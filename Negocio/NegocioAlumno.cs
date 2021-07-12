using Datos_BD;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{

    public class NegocioAlumno
    {
       private BD_Entiti clas = new BD_Entiti();
       
        BD_WCF wcf = new BD_WCF();

        //public List<Alumnos> Consultar() => clas.Consultar();
        public List<Alumnos> Consultar() => wcf.Consultar();
        public List<Estados> ConsultarEstado() => clas.consultarEstado();
        public List<EstatusAlumnos> ConsultarEstatus() => clas.consultarEstatus();
        //public Alumnos detail(int id ) => clas.detail(id);
        ///aqui se llama al WCF que se instancio
        ///
        public Alumnos detail(int id) => wcf.detailWCF(id);
        public void Crear(Alumnos alumnos) => wcf.crear(alumnos);
        //public void Actualizar(Alumnos alumnos) => clas.Actualizar(alumnos);
        public void Editar2(Alumnos alumnos) => wcf.Actualizar(alumnos);
        public Alumnos Editar(int id) => clas.detail(id);
        //public void Editar2(Alumnos alumno) => clas.Edit2(alumno);

        public void Eliminar(int id) => clas.Eliminar(id);



    }
}
