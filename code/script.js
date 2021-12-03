let Nv=0
const X = [0,0,0,0,0,0,0,0,0]
const O = [0,0,0,0,0,0,0,0,0]
function jv(num){
  Nv+=1
  const b1=document.getElementById("b1")
  const b2=document.getElementById("b2")
  const b3=document.getElementById("b3")
  const b4=document.getElementById("b4")
  const b5=document.getElementById("b5")
  const b6=document.getElementById("b6")
  const b7=document.getElementById("b7")
  const b8=document.getElementById("b8")
  const b9=document.getElementById("b9")
  if(Nv%2==0){
    //Lado do player X
    JogadorX(num)    
  }else{
    //Lado player O
    JogadorO(num)   
  }
  // Logica de ganhador
    Resultado(X,O)
}
const JogadorX = function(num){
  switch (num){
    case 1:
      b1.innerHTML="X"
      X[0]=1
      console.log(`B1=${X[1]}`)
      break;
    case 2:
      b2.innerHTML="X"
      X[1]=1
      console.log(`B2=${X[2]}`)
      break;
    case 3:
      b3.innerHTML="X"
      X[2]=1
      console.log(`B3=${X[3]}`)
      break;
    case 4:
      b4.innerHTML="X"
      X[3]=1
      console.log(`B4=${X[4]}`)
      break;
    case 5:
      b5.innerHTML="X"
      X[4]=1
      console.log(`B5=${X[5]}`)
      break;
    case 6:
      b6.innerHTML="X"
      X[5]=1
      console.log(`B6=${X[6]}`)
      break;
    case 7:
      b7.innerHTML="X"
      X[6]=1
      console.log(`B7=${X[7]}`)
      break;
    case 8:
      b8.innerHTML="X"
      X[7]=1
      console.log(`B8=${X[8]}`)
      break;
    case 9:
      b9.innerHTML="X"
      X[8]=1
      console.log(`B9=${X[9]}`)
      break;
    default:
      alert("[ERRO!]")
      break;
  }
}
const JogadorO = function(num){
  switch(num){
    case 1:
        b1.innerHTML="O"
        O[1]=2
        console.log(`B1=${O[1]}`)
        break;
      case 2:
        b2.innerHTML="O"
        O[2]=2
        console.log(`B2=${O[2]}`)
        break;
      case 3:
        b3.innerHTML="O"
        O[3]=2
        console.log(`B3=${O[3]}`)
        break;
      case 4:
        b4.innerHTML="O"
        O[4]=2
        console.log(`B4=${O[4]}`)
        break;
      case 5:
        b5.innerHTML="O"
        O[5]=2
        console.log(`B5=${O[5]}`)
        break;
      case 6:
        b6.innerHTML="O"
        O[6]=2
        console.log(`B6=${O[6]}`)
        break;
      case 7:
        b7.innerHTML="O"  
        O[7]=2
        console.log(`B7=${O[7]}`)
        break;
      case 8:
        b8.innerHTML="O"
        O[8]=2
        console.log(`B8=${O[8]}`)
        break;
      case 9:
        b9.innerHTML="O"
        O[9]=2
        console.log(`B9=${O[9]}`)
        break;
      default:
        alert("[ERRO!]")
        break;
    } 
}
const Resultado = function(X,O){
  if(X[0]+X[1]+X[2]==3 || X[3]+X[4]+X[5]==3 || X[6]+X[7]+X[8]==3 || X[0]+X[3]+X[6]==3 || X[1]+X[4]+X[7]==3 || X[2]+X[5]+X[8]==3 || X[0]+X[4]+X[8]==3 || X[2]+X[4]+X[6]==3){
    alert("[O Ganhador foi X!]")
  }else if(O[1]+O[2]+O[3]==6 || O[4]+O[5]+O[6]==6 || O[7]+O[8]+O[9]==6 || O[1]+O[4]+O[7]==6 || O[2]+O[5]+O[8]==6 || O[3]+O[6]+O[9]==6 || O[1]+O[5]+O[9]==6 || O[3]+O[5]+O[7]==6){
    alert("[O Ganhador foi O!]")
  }else if(X[1]+X[2]+X[3]+X[4]+X[5]+X[6]+X[7]+X[8]+X[9]==4||O[1]+O[2]+O[3]+O[4]+O[5]+O[6]+O[7]+O[8]+O[9]==10){
    alert("[VELHAAA!]")
  }
}