using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections;
using System.Security.AccessControl;
using System;
using System.Linq;
using System.Collections.Generic;
using BeautyInternational.App.Dominio;

namespace BeautyInternational.App.Persistencia{
    public class RepositorioClsCliente : IRepositorioClsCliente{
        private readonly AppContext _appContext;
        public RepositorioClsCliente(AppContext appContext){
            _appContext=appContext;
        }

        ClsCliente IRepositorioClsCliente.AddClientes(ClsCliente cliente){
        var clienteAdicionado = _appContext.Clientes.Add(cliente);
        _appContext.SaveChanges();
        return clienteAdicionado.Entity;
        }

        void IRepositorioClsCliente.DeleteCliente(int idCliente){
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.id== idCliente);
            if(clienteEncontrado==null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ClsCliente> IRepositorioClsCliente.GetAllClientes(){
            return _appContext.Clientes;
        }

        ClsCliente IRepositorioClsCliente.GetCliente(int idCliente){
            return _appContext.Clientes.FirstOrDefault(p => p.id== idCliente);
        }

        ClsCliente IRepositorioClsCliente.UpdateCliente(ClsCliente cliente){
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.id== cliente.id);
            if (clienteEncontrado!=null){
                clienteEncontrado.nombre = cliente.nombre;
                clienteEncontrado.apellido = cliente.apellido;
                clienteEncontrado.genero = cliente.genero;
                clienteEncontrado.celular = cliente.celular;
                clienteEncontrado.direccion = cliente.direccion;
                clienteEncontrado.fechaNacimiento = cliente.fechaNacimiento;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
    }
}