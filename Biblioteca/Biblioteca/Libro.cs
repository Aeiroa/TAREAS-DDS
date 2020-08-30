﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

enum Estado
{
    EnBiblioteca = 0,
    Prestado = 1,
    EnRetraso = 2,
    EnReparacion = 3
}

namespace Biblioteca
{
    class Libro
    {
        private int idLibro;
        private int anio;
        private String categoria;
        private String editorial;
        private int idAutor;
        private Estado estado;
        private String nombre;
        private List<Prestamo> prestamos;
        private Autor autor;

        public void setEstado(Estado unEstado) { estado = unEstado; }

        public void setLibro(int id, int unAnio, String unaCategoria, String unaEditorial, int autorId, Estado unEstado, String unNombre, Autor unAutor) {
            idLibro = id;
            anio = unAnio;
            categoria = unaCategoria;
            editorial = unaEditorial;
            idAutor = autorId;
            estado = unEstado;
            nombre = unNombre;
            autor = unAutor;
        }

        public Boolean cumpleCondicionesPrestamo()
        {
            switch (estado)
            {
                case Estado.EnBiblioteca:
                    return true;
                case Estado.EnReparacion:
                    Console.WriteLine("Se encuentra en reparación.");
                    return false;
                case Estado.EnRetraso:
                    Console.WriteLine("Se encuentra en retraso.");
                    return false;
                case Estado.Prestado:
                    Console.WriteLine("Se encuentra prestado.");
                    return false;
            }
            return false;
        }

    }
}