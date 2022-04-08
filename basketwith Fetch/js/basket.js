let basketSale=document.getElementById("baketCountType");
let table=document.getElementById("table");
let newArray=JSON.parse(localStorage.getItem("basket")); //locats-de datami goturdum

function addBasketDetail(){
    basketSale.innerText=(JSON.parse(localStorage.getItem("basket"))).length;
}

addBasketDetail();

newArray.forEach(element => {
   let tr=document.createElement("tr");
   let tdImage=document.createElement("td");
   let img=document.createElement("img");
   img.setAttribute("src",element.src);
   tdImage.append(img);

   let tdName=document.createElement("td");
   tdName.innerText=element.name;
   

   let tdPrice=document.createElement("td");
   tdPrice.innerText=element.price;

   let tdCount=document.createElement("td");
   tdCount.innerText=element.count;

   let totalPrice=document.createElement("td");
   totalPrice.innerText=(parseInt(tdCount.innerText)* parseInt(tdPrice.innerText)) +"azn";


   let tdPrivate=document.createElement("input");
   tdPrivate.setAttribute("type","hidden");
   tdPrivate.setAttribute("value",`${element.id}`);

   let tdRemove=document.createElement("td");
   tdRemove.innerHTML="<i class=\"fa-solid fa-trash\"></i>"
   tdRemove.setAttribute("data-id", element.id);
   tdRemove.onclick=function(e){
       const deleteid = e.target.parentElement.getAttribute("data-id")
    //    console.log(newArray.length)
    //    console.log(tdPrivate.value)
    //    console.log(element.name)
    //    console.log(newArray.indexOf(element))
    //    let index = newArray.indexOf(element)
    //    newArray.slice(index)
    //    console.log(newArray.length)
    Delete(deleteid)
    addBasketDetail()
    location.reload()
   }

   tr.append(tdPrivate,tdImage,tdName,tdCount,tdPrice,totalPrice,tdRemove);
   table.lastElementChild.append(tr);

});

function Delete(id){
//let items = localStorage.getItem("basket")
newArray.forEach(function(element, index){
    if(element.id==id) 
    newArray.splice(index, 1);

})
localStorage.setItem("basket", JSON.stringify(newArray));
}

localStorage.setItem("basket",JSON.stringify(newArray));
