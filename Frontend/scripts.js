function allowDrop(ev) {
    ev.preventDefault();
}
  
function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
}

async function getData(){
    const response = await fetch("https://localhost:7071/api/WorkItem/GetWorkItems");
    console.log(response);
    const data = await response.json();
    console.log(data);
    lenght = data.lenght;
    var temp ="";

    
}