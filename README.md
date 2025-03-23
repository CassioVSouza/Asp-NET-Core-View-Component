<h1> Asp NET Core View Component</h1>

A very basic writen code that helped me understand how View Components can be used to make real time updates without refresh the page

<h3>How it works</h3>

It's used a mock list to fake some movies data

when the page is rendered, the "Categorias" View Component will get all categories in the list and create a select in HTML

when the page is rendered, the "FilmesLista" View Component will get all movies e create a table to show them

It's possible to send some data to filter the movies

when the button "Pesquisar" is clicked, using Ajax, the View Component "FilmesLista" will be called again using the Controller to retur a new HTML that will be replaced by the old one using JavaScript

