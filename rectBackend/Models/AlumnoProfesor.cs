﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectBackend.Models
{
    public class AlumnoProfesor
    {
        public int Id { get; set; }

        public string Dni { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public int Edad { get; set; }

        public string Email { get; set; }

        public string asignatura { get; set; }
    }
}
