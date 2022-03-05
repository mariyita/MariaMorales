//$("h1").css("color", "green");
//$(".Nombre-cliente").val("hi");


//Definir el evento click para el boton guardar
$("#btnGuardar").click(function () {
  //  alert("Hola soy el evento click");
    //obtener el valor del input Nombre-cliente
    var nombrecliente = $(".Nombre").val();
    //obtener el valor del input Apellido-cliente
    var apellidocliente = $(".Apellido").val();
    var telefono = $(".Telefono").val();
    var direccion = $(".Direccion").val();
    var cedula = $(".Cedula").val();
    // derjaer caer los valorees
   // $(".contenedor").text(nombrecliente + " - " + apellidocliente);

    // validar que los campos sean requeridos
    if (nombrecliente == "" || apellidocliente == ""){
      //  alert("el campo es requerido")
        Swal.fire({
            icon: 'warning',
            title: 'Error',
            text: 'Todos los campos son requeridos'

        });

    }
        else {
            //hacer la pedicion la servidor
        //utilizar ajax

      //  var ajax = $.ajax({

           // jgkghdf
      //  })

        var xhr = $.ajax({
            //url de destrino
            url: "CrearCliente",
            type: "POST",
            //agrrgar paramertro de petcicion
            data: {
                "Nombre": nombrecliente,
                "Apellido": apellidocliente,
                "Telefono": telefono,
                "Direccion": direccion,
                "Cedula": cedula
            }
        });

        //mensaje de respuesta
        xhr.done(function (data) {
            if (data.success) {
                Swal.fire(
                    'Good job',
                    data.message,
                    'success'
                    )
                $(".Nombre").val("");
                $(".Apellido").val("");
                $(".Telefono").val("");
                $(".Direccion").val("");
                $(".Cedula").val("");
                console.log(data);
            }

           
           
        });

        xhr.fail(function () {
            Swal.fire({
                icon: 'warning',
                title: 'Error',
                text: 'Error al guardar!',

            });
        })
       
    }
});