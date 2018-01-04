$(document).ready(function () {
    $(".datepicker").val(GetFormatedDate());
    var dateToday = new Date();
    $("#fechaInicio").datepicker({
        changeMonth: true,
        changeYear: true,
        yearRange: "-2:+0",
        dateFormat: 'yy-mm-dd',
        maxDate: dateToday
    });
    $("#fechaFin").datepicker({
        changeMonth: true,
        changeYear: true,
        yearRange: "-0:+2",
        dateFormat: 'yy-mm-dd',
        minDate: dateToday
    });

    $('#save-button').on('click', function () {
        var $btn = $(this).button('loading');
        $('#cancel-button').attr('disabled', '');
        $('#close-button').attr('disabled', '');
    });
    $('#ordenDeProduccion_Bultos').on('input', function () {
        var valueBultos = $('#ordenDeProduccion_Bultos').val();
        var valueUnidades = $('#ordenDeProduccion_UnidadesPorBulto').val();
        var valueFraccion = $('#ordenDeProduccion_Fraccion').val();
        if (valueBultos !== null && valueUnidades !== null && valueFraccion !== null) {
            var multip = (valueBultos * valueUnidades) + parseInt(valueFraccion);
            $('#ordenDeProduccion_TotalCalculado').attr('Value', multip.toString());
            $('#ordenDeProduccion_TotalCalculado').text(multip.toString());
        }
    });
    $('#ordenDeProduccion_UnidadesPorBulto').on('input', function () {
        var valueBultos = $('#ordenDeProduccion_Bultos').val();
        var valueUnidades = $('#ordenDeProduccion_UnidadesPorBulto').val();
        var valueFraccion = $('#ordenDeProduccion_Fraccion').val();
        if (valueBultos !== null && valueUnidades !== null && valueFraccion !== null) {
            var multip = (valueBultos * valueUnidades) + parseInt(valueFraccion);
            $('#ordenDeProduccion_TotalCalculado').attr('Value', multip.toString());
            $('#ordenDeProduccion_TotalCalculado').text(multip.toString());
        }
    });
    $('#ordenDeProduccion_Fraccion').on('input', function () {
        var valueBultos = $('#ordenDeProduccion_Bultos').val();
        var valueUnidades = $('#ordenDeProduccion_UnidadesPorBulto').val();
        var valueFraccion = $('#ordenDeProduccion_Fraccion').val();
        if (valueBultos !== null && valueUnidades !== null && valueFraccion !== null) {
            var multip = (valueBultos * valueUnidades) + parseInt(valueFraccion);
            $('#ordenDeProduccion_TotalCalculado').attr('Value', multip.toString());
            $('#ordenDeProduccion_TotalCalculado').text(multip.toString());
        }
    });
});
function IfSend() {
    var valueBultos = $('#ordenDeProduccion_Bultos').val();
    var valueUnidades = $('#ordenDeProduccion_UnidadesPorBulto').val();
    var valueFraccion = $('#ordenDeProduccion_Fraccion').val();
    if (valueBultos !== null && valueUnidades !== null && valueFraccion !== null) {
        var totalCalculadoAnteriormente = $('#totalCalculado_Hidden').val();
        var multip = (valueBultos * valueUnidades) + parseInt(valueFraccion) + parseInt(totalCalculadoAnteriormente);
        var maximoAceptado = $('#ordenDeProduccion_MaximoAceptadoPorCliente').val();
        //alert(maximoAceptado);
        if (multip > maximoAceptado) {
            //$('#save_button').prop('disabled', true);
            $('#SubmitMessage').text("El valor ingresado presenta un excedente. Máximo: " +
                maximoAceptado + " ingresado: " + multip + ". Excedente de: " + (multip - maximoAceptado) + " ¿desea continuar?");
        } else if (multip === maximoAceptado) {
            //$('#save_button').prop('disabled', false);
            $('#SubmitMessage').text("El proceso de guardado enviará un correo a los responsables de producto terminado, además " +
                "de guardar la información del lote ¿desea continuar?");
        } else {
            //$('#save_button').prop('disabled', false);
            $('#SubmitMessage').text("Se hará ingreso de los valores a producto terminado ¿desea continuar?");
        }
    }
}
function thousandSeparator(name) {
    if (document.getElementById(name).value !== null) {
        var inputValue = $('#' + name).val();
        var input = inputValue.replace(/[^\d\.]+/g, "");
        if (input.charAt(input.length - 1) !== '.') {
            input = input ? parseFloat(input, 10) : 0;
            $('#' + name).val(function () {
                return input;
            });
        }
    }
}

function GetFormatedDate()
{
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) {
        dd = '0' + dd;
    }
    if (mm < 10) {
        mm = '0' + mm;
    }
    var today = yyyy + '-' + mm + '-' + dd;
    return today;
}