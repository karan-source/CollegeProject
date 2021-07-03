var addToFav = document.getElementsByClassName("add-to-fav");

var movieId = document.getElementsByClassName("movie-id");
var movieImage = document.getElementsByClassName("movie-image");
var movieTitle = document.getElementsByClassName("movie-title");
var movieRelease = document.getElementsByClassName("movie-type");
var movieGenre = document.getElementsByClassName("movie-genre");

for (let i = 0; i < addToFav.length; i++) {
    addToFav[i].addEventListener("click", function () {
        $(document).ready(function () {

            var jsondata = new FormData();
            jsondata.append("Id", movieId[i].value);
            jsondata.append("Title", movieTitle[i].innerText);
            jsondata.append("Release", movieRelease[i].innerText);
            jsondata.append("Genre", movieGenre[i].innerText);
            jsondata.append("Image", movieImage[i].src);

            $.ajax({
                url: "/Home/AddToFav",
                method: "POST",
                data: jsondata,
                contentType: false,
                cache: false,
                processData: false,
                dataType: 'json',
                success: function (data) {
                    if (data == 1) {
                        alert("Added to favourite");
                    } else if (data == 2) {
                        alert("Already Added");
                    }
                },
                error: function (errMsg) {
                    alert(JSON.stringify(errMsg));
                }
            });
        });
    });
}
