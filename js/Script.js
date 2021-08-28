var w,Nv=0,pl
var b1=document.getElementById("b1")
var b2=document.getElementById("b2")
var b3=document.getElementById("b3")
var b4=document.getElementById("b4")
var b5=document.getElementById("b5")
var b6=document.getElementById("b6")
var b7=document.getElementById("b7")
var b8=document.getElementById("b8")
var b9=document.getElementById("b9")

function jv(num){
  console.log(num)
  Nv+=1
  console.log(Nv)
  if(Nv%2==0){
    console.log("X")
    switch (num){
      case 1:
        console.log(num)
        b1.innerHTML="X"
        b1
        break;
      case 2:
        console.log()
        b2.innerHTML="X"
        break;
      case 3:
        console.log()
        b3.innerHTML="X"
        break;
      case 4:
        console.log()
        b4.innerHTML="X"
        break;
      case 5:
        console.log()
        b5.innerHTML="X"
        break;
      case 6:
        console.log()
        b6.innerHTML="X"
        break;
      case 7:
        console.log()
        b7.innerHTML="X"
        break;
      case 8:
        console.log()
        b8.innerHTML="X"
        break;
      case 9:
        console.log()
        b9.innerHTML="X"
        break;
      default:
        alert("[ERRO!]")
        break;
    }
  }else{
      console.log("O")
    switch(num){
    case 1:
        console.log(num)
        b1.innerHTML="O"
        break;
      case 2:
        console.log()
        b2.innerHTML="O"
        break;
      case 3:
        console.log()
        b3.innerHTML="O"
        break;
      case 4:
        console.log()
        b4.innerHTML="O"
        break;
      case 5:
        console.log(num)
        b5.innerHTML="O"
        break;
      case 6:
        console.log()
        b6.innerHTML="O"
        break;
      case 7:
        console.log()
        b7.innerHTML="O"  
      case 8:
        console.log()
        b8.innerHTML="X"
        break;
      case 9:
        console.log()
        b9.innerHTML="X"
        break;
      default:
        alert("[ERRO!]")
        break;
    } 
  }
  if(b1+b2+b3 ==3 || b4+b5+b6 ==3 ||b7+b8+b9 ==3 || b1+b4+b7 ==3 || b2+b5+b8 ==3 ||b3+b6+b9 ==3||b1+b5+b9==3||b3+b5+b7==3){
    alert("X Ganhou!")
  }else if(b1+b2+b3 ==0 || b4+b5+b6 ==0 ||b7+b8+b9 ==0 || b1+b4+b7 ==0 || b2+b5+b8 ==0 ||b3+b6+b9 ==0||b1+b5+b9==0||b3+b5+b7==0){
    alert("O Ganhou!")
  }else{
    alert("Deu velha!")
  }
  if(Nv===9){
    alert("Fim de Jogo!")
  }
}