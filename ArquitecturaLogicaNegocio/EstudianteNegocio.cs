﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquitecturaDatos;
using ArquitecturaEntidades;

namespace ArquitecturaLogicaNegocio
{
    public static class EstudianteNegocio
    {
        public static EstudianteEntidad GuardarEstudiante(EstudianteEntidad estudiante)
        {
            if (estudiante.Id == 0)
            {
                return EstudianteDatos.NuevoEstudiante(estudiante);
            }
            return EstudianteDatos.ActualizarEstudiante(estudiante);

        }
        public static List<EstudianteEntidad> DevolverListaEstudiantes()
        {
             return EstudianteDatos.DevolverListaEstudiantes();
        }

        public static List<EstudianteEntidad> DevolverListaEstudiantesFiltro(FiltradorBuilderEntidad filtro) {
            return EstudianteDatos.DevolverListaEstudiantesFiltro(filtro);
        }

        public static EstudianteEntidad DevolverEstudianteId(int id)
        {
            return EstudianteDatos.DevolverEstudianteId(id);
        }

        public static bool EliminarEstudianteID(int id)
        {
            return EstudianteDatos.EliminarEstudiante(id);
        }
    }
}
