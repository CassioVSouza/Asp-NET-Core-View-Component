$(function(){

    $('#Pesquisar').on('click', function () {

        let Categoria = $('#Categoria').val();
        let Nome = $('#Nome').val();
        let Ano = $('#Ano').val();

        let requisicao = '';

        if (Categoria != '') {
            requisicao += `&Categoria=${Categoria}`;
        }
        if (Nome != '') {
            requisicao += `&Nome=${Nome}`;
        }
        if (Ano != '') {
            requisicao += `&AnoLancamento=${Ano}`;
        }


        $.ajax({

            url: `/Home/FilmesAjax?${requisicao}`,
            type: 'GET',
            success: function (result) {
                $('#Filmes').html(result);
            }
        });
    });
});