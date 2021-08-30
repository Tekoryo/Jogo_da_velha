var Nv=0
function jv(num){
var b1=document.getElementById("b1")
var b2=document.getElementById("b2")
var b3=document.getElementById("b3")
var b4=document.getElementById("b4")
var b5=document.getElementById("b5")
var b6=document.getElementById("b6")
var b7=document.getElementById("b7")
var b8=document.getElementById("b8")
var b9=document.getElementById("b9")
var B1,B2,B3,B4,B5,B6,B7,B8,B9
  console.log(num)
  Nv+=1
  console.log(`Nv é ${Nv}`)
  if(Nv%2==0){
    switch (num){
      case 1:
        B1="X"
        console.log(b1)
        b1.innerHTML="X"
        break;
      case 2:
        console.log(b2)
        b2.innerHTML="X"
        B2=1
        break;
      case 3:
        console.log(b3)
        b3.innerHTML="X"
        B3=1
        break;
      case 4:
        console.log(b4)
        b4.innerHTML="X"
        B4=1
        break;
      case 5:
        console.log(b5)
        b5.innerHTML="X"
        B5="X"
        break;
      case 6:
        console.log(b6)
        b6.innerHTML="X"
        B6=1
        break;
      case 7:
        console.log(b7)
        b7.innerHTML="X"
        B7=1
        break;
      case 8:
        console.log(b8)
        b8.innerHTML="X"
        B8=1
        break;
      case 9:
        console.log(b9)
        b9.innerHTML="X"
        B9="X"
        break;
      default:
        alert("[ERRO!]")
        break;
    }
  }else{
      console.log("O")
    switch(num){
    case 1:
        b1.innerHTML="O"
        b1=2
        console.log(b1)
        break;
      case 2:
        b2.innerHTML="O"
        b2=2
        console.log(b2)
        break;
      case 3:
        b3.innerHTML="O"
        b3=2
        console.log(b3)
        break;
      case 4:
        b4.innerHTML="O"
        b4=2
        console.log(b4)
        break;
      case 5:
        b5.innerHTML="O"
        b5=2
        console.log(b5)
        break;
      case 6:
        b6.innerHTML="O"
        b7=2
        console.log(b6)
        break;
      case 7:
        b7.innerHTML="O"  
        b7=2
        console.log(b7)
        break;
      case 8:
        b8.innerHTML="O"
        b8=2
        console.log(b8)
        break;
      case 9:
        b9.innerHTML="O"
        b9=2
        console.log(b9)
        break;
      default:
        alert("[ERRO!]")
        break;
    } 
  }
  if(B1+B2+B3 ==3 || B4+B5+B6 ==3 ||B7+B8+B9==3 || B1+B4+B7 ==3 || B2+B5+B8 ==3 ||B3+B6+B9 ==3||B1=="X"&&B5=="X"&&B9=="X"||B3+B5+B7==3){
    alert("X Ganhou!")
  }else if(b1+b2+b3 ==6 || b4+b5+b6 ==6 ||b7+b8+b9 ==6 || b1+b4+b7 ==6 || b2+b5+b8 ==6 ||b3+b6+b9 ==6||b1+b5+b9==6||b3+b5+b7==6){
    alert("O Ganhou!")
  }else if(Nv>=9){
    alert("Deu velha!")
  }
}