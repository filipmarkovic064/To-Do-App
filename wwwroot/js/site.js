// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//JavaScript to Open/Close Modal 
    // Get modal and elements
    const modal = document.getElementById("taskModal");
    const openModalBtn = document.getElementById("openModalBtn");
    const closeModalBtn = document.getElementsByClassName("close")[0];

    // When the "+" button is clicked, open the modal
    openModalBtn.onclick = function() {
        modal.style.display = "flex";
    }

    // When the "X" button is clicked, close the modal
    closeModalBtn.onclick = function() {
        modal.style.display = "none";
    }

    // Close the modal if user clicks outside of the modal content
    window.onclick = function(event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }