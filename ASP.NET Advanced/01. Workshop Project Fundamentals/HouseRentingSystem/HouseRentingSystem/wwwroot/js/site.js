function statistics() {

    $('#statistics-button').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        if ($('#statistics').hasClass('d-none'))
        {
            $.get('https://localhost:7289/api/statistics', function (data) {
                $('#total-houses').text(data.totalHouses + " Houses");
                $('#total-rents').text(data.totalRents + " Rents");

                $('#statistics').removeClass('d-none');

                $('#statistics-button').text('Hide Statistics');
                $('#statistics-button').removeClass('btn-primary');
                $('#statistics-button').addClass('btn-danger');
            });
        }
        else
        {
            $('#statistics').addClass('d-none');

            $('#statistics-button').text('Show Statistics');
            $('#statistics-button').removeClass('btn-danger');
            $('#statistics-button').addClass('btn-primary');
        }
        
    });
}


//Check TotalHouses Lower/Upper