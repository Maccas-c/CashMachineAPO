const Owner =  [
  {
    id:"1",
    name: 'Maciek',
    surname: 'Janek',
    pin: '1234',
    balance: '100000$' 
  },
  { id:"2",
    name: 'Maciek',
    surname: 'Janek',
    pin: '3333',
    balance: '2550$' 

  },
  {
  id: "3", 
  name: 'Maciek',
  surname: 'Janek',
  pin: '4444',
  balance: '2500$' },
  {
    id: "4",
    name: "Jan",
    surname:"Nowak",
    pin:"5000",
    balance:"3000$"
  }
]
function continueATM() {
  alert("1.Sprawdzenie stanu konta")
  alert("2.Wpłata pieniedzy")
  alert("3.Wyplata pieniedzy")
  alert("4.Koniec")
}
function Menu() {
  alert("Witaj w bankomacie ATM. Wybierz jedna z 4 opcji");
  alert("1.Sprawdzenie stanu konta")
  alert("2.Wpłata pieniedzy")
  alert("3.Wyplata pieniedzy")
  alert("4.Koniec")
  };

function depositCash(Owner,cash){
   let nowbalance = getbalance(Owner);
   let afterbalance = parseInt(nowbalance) + parseInt(cash);
   return afterbalance;

}

function withdrawCash(Owner,cash){
  let nowbalance = getbalance(Owner);
  let afterbalance = parseInt(nowbalance) - parseInt(cash);
  return afterbalance;
}


function searchpin(pin){
  if(pin == Owner[0].pin)
  {
    return Owner[0]
  }
  else if (pin == Owner[1].pin){
    return Owner[1]
  }
  else if (pin == Owner[2].pin){
    return Owner[2]
  }
  else if (pin == Owner[3].pin){
    return Owner[3]
  }
  else {
    return console.log("Nie ma takiego uzytkownika")
  }
}


function getbalance(Owner){
  return Owner.balance
}


let b = true;
Menu()

const exitcommand = "";
const pin = prompt("Wprowadz wartosc PIN");
const pinOwner = searchpin(parseInt(pin));

while(exitcommand != 4){
var action = prompt("Wprowadz co chcesz zrobic");
    if(action=="1"){
      alert("Stan konta to:" + getbalance(pinOwner));
      continueATM()
    }
    else if (action=="2"){
      money = prompt("Wprowadz wartosc jaka chcesz wplacic:")
      alert("Stan konta po transakcji to :" + depositCash(pinOwner,money)+ "$")
      continueATM()
    }
    else if(action=="3"){
      money = prompt("Wprowadz wartosc jaka chcesz wyplacic:")
      alert("Stan konta po transakcji to :" + withdrawCash(pinOwner,money) + "$")
      continueATM()
    }
    else {
      var goodbye = alert("Koniec");
      exitcommand = 5;
    }
  } 
