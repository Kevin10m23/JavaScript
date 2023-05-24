function openMenu(){
    document.getElementById("mainMenu").style.width="480px";//vista en celular//
    document.getElementById("mainMenu").style.display="flex";//vista en celular//
    document.getElementById("mainMenu").style.height="1000px";//vista en celular//
    document.getElementById("openMenu").style.display="none";//vista en celular//
    }
    
    function closeNav(){
    document.getElementById("mainMenu").style.width="0";//cerrar vista en celular//
    document.getElementById("mainMenu").style.transition="0.9s all";//cerrar vista en celular//
    window.location.reload()
    }
    
