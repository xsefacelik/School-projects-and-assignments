function sign_in() {
  let box_item = document.querySelector(".box .items-second");
  let box_item_pre = document.querySelector(".box .items-first");
  box_item_pre.style.display = "none";
  box_item.style.display = "flex";
}

function join() {
  let box_item = document.querySelector(".box .items-third");
  let box_item_pre = document.querySelector(".box .items-first");
  box_item_pre.style.display = "none";
  box_item.style.display = "flex";
}

function back_button() {
  let box_item1 = document.querySelector(".box .items-first");
  let box_item2 = document.querySelector(".box .items-second");
  let box_item3 = document.querySelector(".box .items-third");

  if (box_item1.style.display == "none") {
    box_item1.style.display = "flex";
    box_item2.style.display = "none";
    box_item3.style.display = "none";
  } else {
    window.location.href = "/index";
  }
}


async function div_sign_in() {
  let username =document.getElementById("username").value + "";
  let password = document.getElementById("password").value + "";
  
  try {
    const response = await fetch('http://localhost:5001/api/playerLoginCheck?username=' + username + '&password=' + password);
    const player = await response.json();
    let arr = [];
    player.forEach(row => {
      const rowArray = Object.values(row);
      arr.push(rowArray);
    });
    if(arr[0] !== undefined){
      try {
        const response = await fetch('http://localhost:5001/api/playerOnline?username=' + username);
        const exist = await response.json();
        console.log(player.exists);
      } catch {
        return alert('a')
      }
      window.location.href = "/game";
    }
    else{
      alert("Username or password is wrong!");
    }
  } catch {
    return alert('ERROR')
  }
}

async function div_join() {
  let username =document.getElementById("username1").value;
  let password = document.getElementById("password1").value;
  let confirmed_password = document.getElementById("confirmed_password").value;
  
  if(password == confirmed_password && password != ""){
    try {
      const response = await fetch('http://localhost:5001/api/playerJoinCheck?username=' + username + '');
      const player = await response.json();
      
      if(!(player.exists)){
        try {
          const response = await fetch('http://localhost:5001/api/playerInsert?username=' + username + '&password=' + password);
          const add = await response.json();
          if((add.exists)){
            alert("Login is successful!");
            window.location.href = "/login";
          }
        } catch {
          return alert('ERROR')
        }
      }
      else{
        alert("Username is already taken!");
        window.location.href = "/login";
      }
      
    } catch {
      return alert('')
    }
  }
  else{
    alert('The passwords that you entered does not match!')
  }
}

