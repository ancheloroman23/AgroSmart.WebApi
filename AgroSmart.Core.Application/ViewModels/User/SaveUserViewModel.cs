﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AgroSmart.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido.")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Debe ingresar un nombre de usuario.")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Debe ingresar un correo electrónico.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }        

        [Required(ErrorMessage = "Debe ingresar una contraseña con caracteres especiales, numeros y al menos una mayúscula.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas deben coincidir.")]
        [Required(ErrorMessage = "Debe ingresar una contraseña con caracteres especiales, numeros y al menos una mayúscula.")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        public int? SelectRole { get; set; }
        
        public bool IsActive { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile? File { get; set; }
        public string? ImageUser { get; set; }

        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
