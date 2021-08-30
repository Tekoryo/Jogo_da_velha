var w,Nv=0,pl
var b1=document.getElementById("b1")
var b2=document.getElementById("b2")
var b3=document.getElementById("b3")
var b4=document.getElementById("b4")
var b5=document.getElementById("b5")
var b6=document.getElementById("b6")
var b7=document.getElementById("b7")
var b8=document.getElementById("b8")
var A9=document.getElementById("A9")
var res=document.getElementById("res")
function jv(num){
  console.log(num)
  Nv+=1
  console.log(`Nv é ${Nv}`)
  console.log(Nv)
  if(Nv%2==0){
    console.log("X")
    switch (num){
      case 1:
        console.log(num)
        b1.innerHTML="X"
        b1=1
        break;
      case 2:
        console.log()
        b2.innerHTML="X"
        b2=1
        break;
      case 3:
        console.log()
        b3.innerHTML="X"
        b3=1
        break;
      case 4:
        console.log()
        b4.innerHTML="X"
        b4=1
        break;
      case 5:
        console.log()
        b5.innerHTML="X"
        b5=1
        break;
      case 6:
        console.log()
        b6.innerHTML="X"
        b6=1
        break;
      case 7:
        console.log()
        b7.innerHTML="X"
        b7=1
        break;
      case 8:
        console.log()
        b8.innerHTML="X"
        b8=1
        break;
      case 9:
        console.log()
        b9.innerHTML="X"
        b9=1
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
        b1=2
        break;
      case 2:
        console.log()
        b2.innerHTML="O"
        b2=2
        break;
      case 3:
        console.log()
        b3.innerHTML="O"
        b3=2
        break;
      case 4:
        console.log()
        b4.innerHTML="O"
        b4=2
        break;
      case 5:
        console.log(num)
        b5.innerHTML="O"
        b5=2
        break;
      case 6:
        console.log()
        b6.innerHTML="O"
        b7=2
        break;
      case 7:
        console.log()
        b7.innerHTML="O"  
        b7=2
        breaḱ;
      case 8:
        console.log()
        b8.innerHTML="X"
        b8=2
        break;
      case 9:
        console.log()
        A9.innerHTML="X"
        b9=2
        res.innerHTML="ERRADO"
        break;
      default:
        
        alert("[ERRO!]")
        break;
    } 
  }
6
  if(b1+b2+b3 ==3 || b4+b5+b6 ==3 ||b7+b8+b9 ==3 || b1+b4+b7 ==3 || b2+b5+b8 ==3 ||b3+b6+b9 ==3||b1+b5+b9==3||b3+b5+b7==3){
    alert("X Ganhou!")
  }else if(b1+b2+b3 ==6 || b4+b5+b6 ==6 ||b7+b8+b9 ==6 || b1+b4+b7 ==6 || b2+b5+b8 ==6 ||b3+b6+b9 ==6||b1+b5+b9==6||b3+b5+b7==6){
    alert("O Ganhou!")
  }else if(Nv<=9){
    alert("Deu velha!")
  }
}