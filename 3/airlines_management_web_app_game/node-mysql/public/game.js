let username = "";
let money = -1;
let day = -1;
let active_credit_amount = 0;
let financial_turnover = 0;
let airplanes_count = 0;
let airports_count = 0;
let employees_count = 0;
let flight_count = 0;
let ticket_count = 0;
let createFlight_clicked = 0;
let bank_outgoing_for_one_day = 0;
let employee_outgoing_for_one_day = 0;

takePlayerInfo();
async function takePlayerInfo(){
  try{
    const response = await fetch('http://localhost:5001/api/getPlayerInfo?');
    const player = await response.json();
    let arr = [];
    player.forEach(row => {
      const rowArray = Object.values(row);
      arr.push(rowArray);
    });
    username = arr[0][0];
    money = arr[0][1];
    day = arr[0][2];
    if(arr[0][3] !== undefined){
      active_credit_amount = arr[0][3];
    }
    takeCompanyInfo();
    calculateEmployeeSalaryForAll();
    calculateBankCredit();
  } catch {
    return alert('ERROR')
  }
}
async function takeCompanyInfo(){
  try{
    const response = await fetch('http://localhost:5001/api/getCompanyInfo?username=' + username);
    const player = await response.json();
    let arr = [];
    player.forEach(row => {
      const rowArray = Object.values(row);
      arr.push(rowArray);
    });
    if(airplanes_count !== undefined){
      airplanes_count = arr[0][0];
    }
    if(airports_count !== undefined){
      airports_count = arr[1][0];
    }
    if(employees_count !== undefined){
      employees_count = arr[2][0];
    }
    if(flight_count !== undefined){
      flight_count = arr[3][0];
    }
    if(ticket_count !== undefined){
      ticket_count = arr[4][0];
    }
  } catch {
    return alert('ERROR')
  }
  document.getElementById('day-footer').innerText = 'Day: ' + day;
  document.getElementById('airplanes-footer').innerText = 'Planes: ' + airplanes_count;
  document.getElementById('airports-footer').innerText = 'Airports: ' + airports_count;
  document.getElementById('employees-footer').innerText = 'Employees: ' + employees_count;
  document.getElementById('money-footer').innerText = 'Money: $' + money;
  document.getElementById('username-header').innerText = username;
  document.getElementById('flights-footer').innerText = 'Flights: '  + flight_count;
  document.getElementById('tickets-footer').innerText = 'Tickets: ' + ticket_count;
  if(day !== 0)
    stringToHoldArray();
}

async function stringToHoldArray(){
  try {
    const response = await fetch('http://localhost:5001/api/getDayLog?username=' + username + "&day=" + (day - 1));
    const daylogTemp = await response.json();
    let temp = [];
    daylogTemp.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
    });
    let dayLogString = temp[0][0];
    let allElements = dayLogString.split(";");
    holdHireArray = allElements[0].split(",");
    holdDismissArray = allElements[1].split(",");
    holdBuyArray = allElements[2].split(",");
    holdSellArray = allElements[3].split(",");
    holdUnlockArray = allElements[4].split(",");
    tempFlight = allElements[5].split("/");
    for(let i = 0; i < tempFlight.length; i++)
    {
      replacedString = tempFlight[i].replace(/,/g, ';');
      replacedString = replacedString.replace(/-/g, ',');
      holdFlightArray.push(replacedString);
    }

    printHolded("left", "empty");
    holdHireArray = [];
    holdDismissArray = [];
    holdBuyArray = [];
    holdSellArray = [];
    holdUnlockArray = [];
    holdFlightArray = [];
  } catch {
    return alert('ERROR')
  }
}


//Employee
let hire_submit_clicked = false;
let hire_get_array_clicked = 0;
let currentPageHire = 0;
let employeeArrayHire = [];
let hireFilterNameValue = "?";
let hireFilterMinFlightCount = "-1"; 
let hireFilterMaxFlightCount = "-1"; 
let hireFilterProfessionValue = "?";

let dismiss_submit_clicked = false;
let dismiss_get_array_clicked = 0;
let currentPageDismiss = 0;
let employeeArrayDismiss = [];
let dismissFilterNameValue = "?";
let dismissFilterMinFlightCount = "-1"; 
let dismissFilterMaxFlightCount = "-1"; 
let dismissFilterProfessionValue = "?";

let show_submit_clicked = false;
let show_get_array_clicked = 0;
let currentPageShow = 0;
let employeeArrayShow = [];
let showFilterNameValue = "?";
let showFilterMinFlightCount = "-1"; 
let showFilterMaxFlightCount = "-1"; 
let showFilterProfessionValue = "?";


//Airplane
let buy_airplane_submit_clicked = false;
let buy_airplane_get_array_clicked = 0;
let currentPageBuyAirplane = 0;
let airplaneArrayBuy = [];
let buyAirplaneType1Checked = "false";
let buyAirplaneType2Checked = "false";
let buyAirplaneType3Checked = "false";

let sell_airplane_submit_clicked = false;
let sell_airplane_get_array_clicked = 0;
let currentPageSellAirplane = 0;
let airplaneArraySell = [];
let sellAirplaneType1Checked = "false";
let sellAirplaneType2Checked = "false";
let sellAirplaneType3Checked = "false";

let show_airplane_submit_clicked = false;
let show_airplane_get_array_clicked = 0;
let currentPageShowAirplane = 0;
let airplaneArrayShow = [];
let showAirplaneType1Checked = "false";
let showAirplaneType2Checked = "false";
let showAirplaneType3Checked = "false";


//Airport
let unlock_airport_submit_clicked = false;
let unlock_airport_get_array_clicked = 0;
let currentPageUnlockAirport = 0;
let airportArrayUnlock = [];
let unlockFilterNameValue = "?";
let unlockFilterCityValue = "?";
let unlockFilterCountryValue = "?";

let show_airport_submit_clicked = false;
let show_airport_get_array_clicked = 0;
let currentPageShowAirport = 0;
let airportArrayShow = [];
let showAirportFilterNameValue = "?";
let showAirportFilterCityValue = "?";
let showAirportFilterCountryValue = "?";


//Flight
let take_off_airport_submit_clicked = false;
let take_off_airport_get_array_clicked = 0;
let currentPageTakeOff = 0;
let flightArrayTakeOff = [];
let takeOffFilterNameValue = "?";
let takeOffFilterCityValue = "?";
let takeOffFilterCountryValue = "?";

let landing_airport_submit_clicked = false;
let landing_airport_get_array_clicked = 0;
let currentPageLanding = 0;
let flightArrayLanding = [];
let landingFilterNameValue = "?";
let landingFilterCityValue = "?";
let landingFilterCountryValue = "?";

let pilot_submit_clicked = false;
let pilot_get_array_clicked = 0;
let currentPagePilot = 0;
let flightArrayPilot = [];
let pilotFilterNameValue = "?";
let pilotFilterMinFlightCount = "-1"; 
let pilotFilterMaxFlightCount = "-1";

let cabin_attendant_submit_clicked = false;
let cabin_attendant_get_array_clicked = 0;
let currentPageCabinAttendant = 0;
let flightArrayCabinAttendant = [];
let cabinAttendantFilterNameValue = "?";
let cabinAttendantFilterMinFlightCount = "-1"; 
let cabinAttendantFilterMaxFlightCount = "-1";

let flight_airplane_submit_clicked = false;
let flight_airplane_get_array_clicked = 0;
let currentPageFlightAirplane = 0;
let airplaneArrayFlight = [];
let flightAirplaneType1Checked = "false";
let flightAirplaneType2Checked = "false";
let flightAirplaneType3Checked = "false";
let flightAirplaneMinPriceValue = "-1";
let flightAirplaneMaxPriceValue = "-1";

let flight_show_submit_clicked = false;
let flight_show_get_array_clicked = 0;
let currentPageShowFlight = 0;
let flightArrayShow = [];
let flightShowFilterMaxDate = "-1";
let flightShowFilterMinDate = "-1";
let flightShowFilterMaxId = "-1";
let flightShowFilterMinId = "-1";

let currentPagePassenger = 0;
let passenger_submit_clicked = false;
let passenger_get_array_clicked = 0;
let passengerFilterNameValue = "?"; 
let passengerFilterGenderValue = "?";
let passenger_details = [];


let route_details = [];
let pilot_details = [];
let cabin_attendant_details = [];
let plane_details = [];
let occupancy_rate = 0;


//employee
function openEmployeeOptions() {
  printHolded("right", "employee");
  let action_div = document.querySelector("section .action");
  let class1 = "employee-options";
  let class2 = "employee-action";
  action_div.innerHTML =
    "<div class=" + class1 + "></div><div class=" + class2 + "></div>";

  let employee_options = document.querySelector(
    "section .action .employee-options"
  );
  
  employee_options.innerHTML =
    '<button onclick="filterHireEmp();hireGetArray();">Hire Employee</button><button onclick="filterDismissEmp(); dismissGetArray();">Dismiss Employee</button><button onclick="filterShowEmp(); showGetArray()">Show Employee</button><button onclick="rewriteOptions(); back();">Back</button>';
}

function hireEmployee() {
  let employee_action = document.querySelector(
    "section .action .employee-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(1)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Salary</th><th>Experience</th><th>Profession</th><th>Hire</th></tr>';

  for (let i = 0; i < 9; i++) {
    let tr_className = "tr_hire_" + i;
    let td_className = "td_hire_" + i;
    let arrayElements = employeeArrayHire[(i) + (currentPageHire * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "hireCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdHireArray.length;j++)
      {
        if(holdHireArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] + " " + arrayElements[4] + "</td><td class = " + td_className + ">"+ calculateEmployeeSalary(arrayElements[3], arrayElements[2]) +"</td><td class = " + td_className + ">"+ expCalculator(arrayElements[2]) +"</td><td class = " + td_className + ">"+ arrayElements[3] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(1)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  employee_action.innerHTML = tableHTML;

  hire_get_array_clicked += 1;
  if(hire_get_array_clicked === 1){
    hireGetArray();
  }
}
async function hireGetArray()
{
  if(hire_get_array_clicked < 2){
    try {
      let first_last = "";
      if(employeeArrayHire[0] === undefined){
        first_last = "first";
      }
      else if(employeeArrayHire[0] !== undefined){
        first_last = "last";
      }

      if(hire_submit_clicked){
        first_last = "submit";
      }
      const response = await fetch('http://localhost:5001/api/employee/hire?first_last=' + first_last + "&hireFilterNameValue=" + hireFilterNameValue + "&hireFilterMinFlightCount=" + hireFilterMinFlightCount + "&hireFilterMaxFlightCount=" + hireFilterMaxFlightCount + "&hireFilterProfessionValue=" + hireFilterProfessionValue);
      const player = await response.json();
      let temp = []
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(employeeArrayHire[0] === undefined || hire_submit_clicked){
        employeeArrayHire = temp;
      }
      else if(employeeArrayHire[0] !== undefined && !hire_submit_clicked){
        employeeArrayHire = employeeArrayHire.concat(temp);
      }
      hireEmployee();
      
    } catch {
      return alert('ERROR')
    }
  }
  else{
    hireEmployee();
  }
}

async function dismissalEmployee() {
  let employee_action = document.querySelector(
    "section .action .employee-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(2)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Salary</th><th>Experience</th><th>Profession</th><th>Dismissal</th></tr>';

  for (let i = 0; i < 9; i++) {
    let tr_className = "tr_dismiss_" + i;
    let td_className = "td_dismiss_" + i;
    let arrayElements = employeeArrayDismiss[(i) + (currentPageDismiss * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "dismissCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdDismissArray.length;j++)
      {
        if(holdDismissArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] + " " + arrayElements[4] + "</td><td class = " + td_className + ">"+ calculateEmployeeSalary(arrayElements[3], arrayElements[2]) +"</td><td class = " + td_className + ">"+ expCalculator(arrayElements[2]) +"</td><td class = " + td_className + ">"+ arrayElements[3] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(2)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  employee_action.innerHTML = tableHTML;

  dismiss_get_array_clicked += 1;
  if(dismiss_get_array_clicked === 1){
    dismissGetArray();
  }
}
async function dismissGetArray()
{
  if(dismiss_get_array_clicked < 2){
    let first_last = "";
    if(employeeArrayDismiss[0] === undefined){
      first_last = "first";
    }
    else if(employeeArrayDismiss[0] !== undefined){
      first_last = "last";
    }
    if(dismiss_submit_clicked){
    first_last = "submit";
    }
    try {
        const response = await fetch('http://localhost:5001/api/employee/dismiss?first_last=' + first_last + '&username=' + username + '&dismissFilterNameValue=' + dismissFilterNameValue + "&dismissFilterMinFlightCount=" + dismissFilterMinFlightCount + "&dismissFilterMaxFlightCount=" + dismissFilterMaxFlightCount + "&dismissFilterProfessionValue=" + dismissFilterProfessionValue);
        const player = await response.json();
    
        let temp = [];
        player.forEach(row => {
          const rowArray = Object.values(row);
          temp.push(rowArray);
        });
        if(employeeArrayDismiss[0] === undefined || dismiss_submit_clicked){
          employeeArrayDismiss = temp;
        }
        else{
          employeeArrayDismiss = employeeArrayDismiss.concat(temp);
        }
        dismissalEmployee();
      } catch {
        return alert('ERROR')
      }
    }
  else{
    dismissalEmployee();
  }
}

async function showEmployee() {
  let employee_action = document.querySelector(
    "section .action .employee-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(3)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Salary</th><th>Experience</th><th>Profession</th></tr>';

  for (let i = 0; i < 9; i++) {
    let className = "class_" + (i + 1);
    let arrayElements = employeeArrayShow[(i) + (currentPageShow * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      className +
      "><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      tableHTML +=
      "<tr class = " +
      className +
      "><td>"+ arrayElements[0] +"</td><td>"+ arrayElements[1] + " " + arrayElements[4] + "</td><td>"+ calculateEmployeeSalary(arrayElements[2], arrayElements[3]) +"</td><td>"+ expCalculator(arrayElements[2]) +"</td><td>"+ arrayElements[3] +"</td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(3)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  employee_action.innerHTML = tableHTML;
}
async function showGetArray()
{
  if(show_get_array_clicked < 2){
    let first_last = "";
    if(employeeArrayShow[0] === undefined){
      first_last = "first";
    }
    else if(employeeArrayShow[0] !== undefined){
      first_last = "last";
    }
    if(show_submit_clicked){
      first_last = "submit";
    }
    try {
      const response = await fetch('http://localhost:5001/api/employee/show?first_last=' + first_last + '&username=' + username + '&showFilterNameValue=' + showFilterNameValue + "&showFilterMinFlightCount=" + showFilterMinFlightCount + "&showFilterMaxFlightCount=" + showFilterMaxFlightCount + "&showFilterProfessionValue=" + showFilterProfessionValue);
      const player = await response.json();
  
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(employeeArrayShow[0] === undefined || show_submit_clicked){
        employeeArrayShow = temp;
      }
      else{
        employeeArrayShow = employeeArrayShow.concat(temp);
      }
      showEmployee();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    showEmployee();
  }
}


//airplane
function openAirplaneOptions() {
  printHolded("right", "airplane");
  let action_div = document.querySelector("section .action");
  let class1 = "airplane-options";
  let class2 = "airplane-action";
  action_div.innerHTML =
    "<div class=" + class1 + "></div><div class=" + class2 + "></div>";

  let airplane_options = document.querySelector(
    "section .action .airplane-options"
  );

  let airplane_action = document.querySelector(
    "section .action .airplane-action"
  );

  airplane_options.innerHTML =
    '<button onclick="filterBuyAirplane(); buyAirplaneGetArray();">Buy Airplane</button><button onclick="filterSellAirplane(); sellAirplaneGetArray();">Sell Airplane</button><button onclick="filterShowAirplane(); showAirplaneGetArray();">Show Airplane</button><button onclick="rewriteOptions(); back();">Back</button>';
}

function buyAirplane() {
  let airplane_action = document.querySelector(
    "section .action .airplane-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(4)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Type</th><th>Price</th><th>Capacity</th><th>Flight Count</th><th>Buy</th></tr>';

  for (let i = 0; i < 9; i++) {
    let tr_className = "tr_buy_" + i;
    let td_className = "td_buy_" + i;;
    let arrayElements = airplaneArrayBuy[(i) + (currentPageBuyAirplane * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "buyCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdBuyArray.length;j++)
      {
        if(holdBuyArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ calculatePlanePrice(arrayElements[1], arrayElements[4]) +"</td><td class = " + td_className + ">"+ (arrayElements[3] + arrayElements[2]) +"</td><td class = " + td_className + ">"+ arrayElements[4] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(4)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  airplane_action.innerHTML = tableHTML;

  buy_airplane_get_array_clicked += 1;
  if(buy_airplane_get_array_clicked === 1){
    buyAirplaneGetArray();
  }
}
async function buyAirplaneGetArray(){
  if(buy_airplane_get_array_clicked < 2){
    try {
      let first_last = "";
      if(airplaneArrayBuy[0] === undefined){
        first_last = "first";
      }
      else if(airplaneArrayBuy[0] !== undefined){
        first_last = "last";
      }

      if(buy_airplane_submit_clicked){
        first_last = "submit";
      }
      const response = await fetch('http://localhost:5001/api/employee/buyAirplane?first_last=' + first_last + "&buyAirplaneType1Checked=" + buyAirplaneType1Checked + "&buyAirplaneType2Checked=" + buyAirplaneType2Checked + "&buyAirplaneType3Checked=" + buyAirplaneType3Checked);
      const plane = await response.json();
      let temp = []
      plane.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(airplaneArrayBuy[0] === undefined || buy_airplane_submit_clicked){
        airplaneArrayBuy = temp;
      }
      else if(airplaneArrayBuy[0] !== undefined && !buy_airplane_submit_clicked){
        airplaneArrayBuy = airplaneArrayBuy.concat(temp);
      }
      buyAirplane();
      
    } catch {
      return alert('ERROR')
    }
  }
  else{
    buyAirplane();
  }
}

function sellAirplane() {
  let airplane_action = document.querySelector(
    "section .action .airplane-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(5)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Type</th><th>Price</th><th>Capacity</th><th>Flight Count</th><th>Sell</th></tr>';

  for (let i = 0; i < 9; i++) {
    let tr_className = "tr_sell_" + i;
    let td_className = "td_sell_" + i;
    let arrayElements = airplaneArraySell[(i) + (currentPageSellAirplane * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "sellCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdSellArray.length;j++)
      {
        if(holdSellArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ calculatePlanePrice(arrayElements[1], arrayElements[4]) +"</td><td class = " + td_className + ">"+ (arrayElements[3] + arrayElements[2]) +"</td><td class = " + td_className + ">"+ arrayElements[4] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(5)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  airplane_action.innerHTML = tableHTML;

  sell_airplane_get_array_clicked += 1;
  if(sell_airplane_get_array_clicked === 1){
    sellAirplaneGetArray();
  }
}
async function sellAirplaneGetArray(){
  if(sell_airplane_get_array_clicked < 2){
    let first_last = "";
    if(airplaneArraySell[0] === undefined){
      first_last = "first";
    }
    else if(airplaneArraySell[0] !== undefined){
      first_last = "last";
    }
    if(sell_airplane_submit_clicked){
      first_last = "submit";
    }

    try {
      const response = await fetch('http://localhost:5001/api/employee/sellAirplane?first_last=' + first_last + '&username=' + username + "&sellAirplaneType1Checked=" + sellAirplaneType1Checked + "&sellAirplaneType2Checked=" + sellAirplaneType2Checked + "&sellAirplaneType3Checked=" + sellAirplaneType3Checked);
      const player = await response.json();
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });

      if(airplaneArraySell[0] === undefined || sell_airplane_submit_clicked){
        airplaneArraySell = temp;
      }
      else{
        airplaneArraySell = airplaneArraySell.concat(temp);
      }
      sellAirplane();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    sellAirplane();
  }
}

function showAirplane() {
  let airplane_action = document.querySelector(
    "section .action .airplane-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(6)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Type</th><th>Price</th><th>Capacity</th><th>Flight Count</th></tr>';

  for (let i = 0; i < 9; i++) {
    let className = "class_" + (i + 1);
    let arrayElements = airplaneArrayShow[(i) + (currentPageShowAirplane * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      className +
      "><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{

      tableHTML +=
      "<tr class = " +
      className +
      "><td>"+ arrayElements[0] +"</td><td>"+ arrayElements[1] +"</td><td>"+ calculatePlanePrice(arrayElements[1], arrayElements[4]) +"</td><td>"+ (arrayElements[3] + arrayElements[2]) +"</td><td>"+ arrayElements[4] +"</td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(6)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  airplane_action.innerHTML = tableHTML;

  show_airplane_get_array_clicked += 1;
  if(show_airplane_get_array_clicked === 1){
    showAirplaneGetArray();
  }
}
async function showAirplaneGetArray(){
  if(show_airplane_get_array_clicked < 2){
    let first_last = "";
    if(airplaneArrayShow[0] === undefined){
      first_last = "first";
    }
    else if(airplaneArrayShow[0] !== undefined){
      first_last = "last";
    }

    if(show_airplane_submit_clicked){
      first_last = "submit";
    }
    try {
      const response = await fetch('http://localhost:5001/api/employee/showAirplane?first_last=' + first_last + '&username=' + username + "&showAirplaneType1Checked=" + showAirplaneType1Checked + "&showAirplaneType2Checked=" + showAirplaneType2Checked + "&showAirplaneType3Checked=" + showAirplaneType3Checked);
      const player = await response.json();
  
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(airplaneArrayShow[0] === undefined || show_airplane_submit_clicked){
        airplaneArrayShow = temp;
      }
      else{
        airplaneArrayShow = airplaneArrayShow.concat(temp);
      }
      showAirplane();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    showAirplane();
  }
}


// airport
function openAirportOptions() {
  printHolded("right", "airport");
  let action_div = document.querySelector("section .action");
  let class1 = "airport-options";
  let class2 = "airport-action";
  action_div.innerHTML =
    "<div class=" + class1 + "></div><div class=" + class2 + "></div>";

  let airport_options = document.querySelector(
    "section .action .airport-options"
  );

  let airport_action = document.querySelector(
    "section .action .airport-action"
  );

  airport_options.innerHTML =
    '<button onclick="filterUnlockAirport(); unlockAirport();">Unlock Airport</button><button onclick="filterShowAirport(); showAirport();">Show Airport</button><button onclick="rewriteOptions(); back();">Back</button>';
}

function unlockAirport() {
  let airport_action = document.querySelector(
    "section .action .airport-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(7)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>City</th><th>Country</th><th>Unlocking Fee</th><th>Unlock</th></tr>';

  for (let i = 0; i < 9; i++) {
    let tr_className = "tr_unlock_" + i;
    let td_className = "td_unlock_" + i;
    let arrayElements = airportArrayUnlock[(i) + (currentPageUnlockAirport * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "unlockCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdUnlockArray.length;j++)
      {
        if(holdUnlockArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ arrayElements[3] +"</td><td class = " + td_className + ">"+ arrayElements[2] +"</td><td class = " + td_className + ">"+ arrayElements[4] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(7)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  airport_action.innerHTML = tableHTML;

  unlock_airport_get_array_clicked += 1;
  if(unlock_airport_get_array_clicked === 1){
    unlockAirportGetArray();
  }
}
async function unlockAirportGetArray(){
  if(unlock_airport_get_array_clicked < 2){
    let first_last = "";
    if(airportArrayUnlock[0] === undefined){
      first_last = "first";
    }
    else if(airportArrayUnlock[0] !== undefined){
      first_last = "last";
    }

    if(unlock_airport_submit_clicked){
      first_last = "submit";
    }
    try{
      const response = await fetch('http://localhost:5001/api/unlockAirport?username='+ username +'&first_last=' + first_last + "&unlockFilterNameValue=" + unlockFilterNameValue + "&unlockFilterCityValue=" + unlockFilterCityValue + "&unlockFilterCountryValue=" + unlockFilterCountryValue);
      const plane = await response.json();
      let temp = []
      plane.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
      });
      if(airportArrayUnlock[0] === undefined || unlock_airport_submit_clicked){
      airportArrayUnlock = temp;
      }
      else if(airportArrayUnlock[0] !== undefined && !unlock_airport_submit_clicked){
        airportArrayUnlock = airportArrayUnlock.concat(temp);
      }
      unlockAirport();
    
    } catch {
      return alert('ERROR')
    }
  }
  else{
    unlockAirport();
  }
}

function showAirport() {
  let airport_action = document.querySelector(
    "section .action .airport-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(8)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>City</th><th>Country</th></tr>';

  for (let i = 0; i < 9; i++) {
    let className = "class_" + (i + 1);
    let arrayElements = airportArrayShow[(i) + (currentPageShowAirport * 9)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      className +
      "><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      tableHTML +=
      "<tr class = " +
      className +
      "><td>"+ arrayElements[0] +"</td><td>"+ arrayElements[1] +"</td><td>"+ arrayElements[3] +"</td><td>"+ arrayElements[2] +"</td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(8)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  airport_action.innerHTML = tableHTML;

  show_airport_get_array_clicked += 1;
  if(show_airport_get_array_clicked === 1){
    showAirportGetArray();
  }
}
async function showAirportGetArray(){
  if(show_airport_get_array_clicked < 2){
    let first_last = "";
    if(airportArrayShow[0] === undefined){
      first_last = "first";
    }
    else if(airportArrayShow[0] !== undefined){
      first_last = "last";
    }
    if(show_airport_submit_clicked){
      first_last = "submit";
    }

    try{
      const response = await fetch('http://localhost:5001/api/showAirport?username='+ username +'&first_last=' + first_last + "&showAirportFilterNameValue=" + showAirportFilterNameValue + "&showAirportFilterCityValue=" + showAirportFilterCityValue + "&showAirportFilterCountryValue=" + showAirportFilterCountryValue);
      const plane = await response.json();
      let temp = []
      plane.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
      });
      if(airportArrayShow[0] === undefined || show_airport_submit_clicked){
        airportArrayShow = temp;
      }
      else if(airportArrayShow[0] !== undefined && !show_airport_submit_clicked){
        airportArrayShow = airportArrayShow.concat(temp);
      }
      showAirport();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    showAirport();
  }
}


//flight
function openFlightOptions() {
  printHolded("right", "flight");
  let action_div = document.querySelector("section .action");
  let class1 = "flight-options";
  let class2 = "flight-action";
  let class3 = "flight-generate"
  action_div.innerHTML =
    "<div class=" + class1 + "></div><div class=" + class2 + "></div><div class=" + class3 + "></div>";

  let airport_options = document.querySelector(
    "section .action .flight-options"
  );

  let airport_action = document.querySelector(
    "section .action .flight-action"
  );
  

  airport_options.innerHTML =
    '<button onclick="generateFlight()">Generate Flight</button><button onclick="showFlight()">Show Flight</button><button onclick="backFlight()">Back</button>';
}

function generateFlight() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );


  let flight_generate = document.querySelector(
    "section .action .flight-generate"
  );


  let innerHTML =
    '<button onclick="filterTakeoff(); takeOffButton();">Take-off</button><button onclick="filterLanding(); landingButton();">Landing</button><button onclick="filterPilot(); pilotButton();">Pilot</button><button onclick="filterCabinAttendant(); cabinAttendantButton();">Cabin Attendant</button><button onclick="filterFlightAirplane(); selectPlaneButton();">Plane</button>';
  flight_action.innerHTML = innerHTML;

  flight_action.style.cssText =
    "display: flex;flex: 8;  width: 90%; height: 60%; justify-content: space-between;  align-items: center;";
  let flight_action_buttons = document.querySelectorAll(
    "section .action .flight-action button"
  );

  flight_action_buttons.forEach(function (button) {
    button.style.cssText = "width: 18%; height: 60%;";
  });

  flight_generate.innerHTML = "<button onclick = 'createFlight()' >Create Flight</button>";
}

function takeOffButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(9)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Country</th><th>City</th><th>Select</th></tr>';

  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_takeoff_" + i;
    let td_className = "td_takeoff_" + i;
    let arrayElements = flightArrayTakeOff[(i) + (currentPageTakeOff * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "takeoffCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdTakeoffArray.length;j++)
      {
        if(holdTakeoffArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ arrayElements[2] +"</td><td class = " + td_className + ">"+ arrayElements[3] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(9)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;

  take_off_airport_get_array_clicked += 1;
  if(take_off_airport_get_array_clicked === 1){
    getTakeOffArray();
  }
}
async function getTakeOffArray(){
  if(take_off_airport_get_array_clicked < 2){
    let first_last = "";
    if(flightArrayTakeOff[0] === undefined){
      first_last = "first";
    }
    else if(flightArrayTakeOff[0] !== undefined){
      first_last = "last";
    }
    if(take_off_airport_submit_clicked){
      first_last = "submit";
    }

    try{
      const response = await fetch('http://localhost:5001/api/takeOff?username='+ username +'&first_last=' + first_last + "&takeOffFilterNameValue=" + takeOffFilterNameValue + "&takeOffFilterCityValue=" + takeOffFilterCityValue + "&takeOffFilterCountryValue=" + takeOffFilterCountryValue);
      const plane = await response.json();
      let temp = []
      plane.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
      });
      if(flightArrayTakeOff[0] === undefined || take_off_airport_submit_clicked){
        flightArrayTakeOff = temp;
      }
      else if(flightArrayTakeOff[0] !== undefined && !take_off_airport_submit_clicked){
        flightArrayTakeOff = flightArrayTakeOff.concat(temp);
      }
      takeOffButton();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    takeOffButton();
  }
}

function landingButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(10)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Country</th><th>City</th><th>Select</th></tr>';

  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_landing_" + i;
    let td_className = "td_landing_" + i;
    let arrayElements = flightArrayLanding[(i) + (currentPageLanding * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "landingCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdLandingArray.length;j++)
      {
        if(holdLandingArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ arrayElements[2] +"</td><td class = " + td_className + ">"+ arrayElements[3] +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(10)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;

  landing_airport_get_array_clicked += 1;
  if(landing_airport_get_array_clicked === 1){
    getLandingArray();
  }
}
async function getLandingArray(){
  if(landing_airport_get_array_clicked < 2){
    let first_last = "";
    if(flightArrayLanding[0] === undefined){
      first_last = "first";
    }
    else if(flightArrayLanding[0] !== undefined){
      first_last = "last";
    }

    if(landing_airport_submit_clicked){
      first_last = "submit";
    }
    try{
      const response = await fetch('http://localhost:5001/api/landing?username='+ username +'&first_last=' + first_last + "&landingFilterNameValue=" + landingFilterNameValue + "&landingFilterCityValue=" + landingFilterCityValue + "&landingFilterCountryValue=" + landingFilterCountryValue);
      const plane = await response.json();
      let temp = []
      plane.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
      });

      if(flightArrayLanding[0] === undefined || landing_airport_submit_clicked){
        flightArrayLanding = temp;
      }
      else if(flightArrayLanding[0] !== undefined && !landing_airport_submit_clicked){
        flightArrayLanding = flightArrayLanding.concat(temp);
      }
      landingButton();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    landingButton();
  }
}

function pilotButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(11)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Experience</th><th>Select</th></tr>';

  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_pilot_" + i;
    let td_className = "td_pilot_" + i;
    let arrayElements = flightArrayPilot[(i) + (currentPagePilot * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "pilotCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdPilotArray.length;j++)
      {
        if(holdPilotArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] + " " + arrayElements[3] + "</td><td class = " + td_className + ">"+ expCalculator(arrayElements[2]) +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(11)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;

  pilot_get_array_clicked += 1;
  if(pilot_get_array_clicked === 1){
    getPilotArray();
  }
}
async function getPilotArray()
{
  if(pilot_get_array_clicked < 2 ||createFlight_clicked){
    let first_last = "";
    if(flightArrayPilot[0] === undefined || createFlight_clicked){
      first_last = "first";
    }
    else if(flightArrayPilot[0] !== undefined){
      first_last = "last";
    }
    if(pilot_submit_clicked){
      first_last = "submit";
    }

    try {
      const response = await fetch('http://localhost:5001/api/pilot?first_last=' + first_last + '&username=' + username + '&pilotFilterNameValue=' + pilotFilterNameValue + "&pilotFilterMinFlightCount=" + pilotFilterMinFlightCount + "&pilotFilterMaxFlightCount=" + pilotFilterMaxFlightCount);
      const player = await response.json();
  
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(flightArrayPilot[0] === undefined || pilot_submit_clicked || createFlight_clicked){
        flightArrayPilot = temp;
      }
      else{
        flightArrayPilot = flightArrayPilot.concat(temp);
      }
      pilotButton();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    pilotButton();
  }
}

function cabinAttendantButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(12)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Experience</th><th>Select</th></tr>';
  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_cabinattendant_" + i;
    let td_className = "td_cabinattendant_" + i;
    let arrayElements = flightArrayCabinAttendant[(i) + (currentPageCabinAttendant * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "cabinAttendantCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdCabinAttendantArray.length;j++)
      {
        if(holdCabinAttendantArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1]  + " " + arrayElements[3] + "</td><td class = " + td_className + ">"+ expCalculator(arrayElements[2]) +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(12)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;
  
  cabin_attendant_get_array_clicked += 1;
  if(cabin_attendant_get_array_clicked === 1){
    getCabinAttendantArray();
  }
}
async function getCabinAttendantArray()
{
  if(cabin_attendant_get_array_clicked < 2 || createFlight_clicked){
    let first_last = "";
    if(flightArrayCabinAttendant[0] === undefined || createFlight_clicked){
      first_last = "first";
    }
    else if(flightArrayCabinAttendant[0] !== undefined){
      first_last = "last";
    }
    if(cabin_attendant_submit_clicked){
      first_last = "submit";
    }

    try {
      const response = await fetch('http://localhost:5001/api/cabinAttendant?first_last=' + first_last + '&username=' + username + '&cabinAttendantFilterNameValue=' + cabinAttendantFilterNameValue + "&cabinAttendantFilterMinFlightCount=" + cabinAttendantFilterMinFlightCount + "&cabinAttendantFilterMaxFlightCount=" + cabinAttendantFilterMaxFlightCount);
      const player = await response.json();
  
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });
      if(flightArrayCabinAttendant[0] === undefined || cabin_attendant_submit_clicked || createFlight_clicked){
        flightArrayCabinAttendant = temp;
      }
      else{
        flightArrayCabinAttendant = flightArrayCabinAttendant.concat(temp);
      }
      cabinAttendantButton();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    cabinAttendantButton();
  }
}

function selectPlaneButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(13)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Type</th><th>Capacity</th><th>Select</th></tr>';

  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_plane_" + i;
    let td_className = "td_plane_" + i;
    let arrayElements = airplaneArrayFlight[(i) + (currentPageFlightAirplane * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      let checkBoxId = "planeCheckbox" + (arrayElements[0]);
      let checkBoxIdStr = "id = '" + checkBoxId + "'";
      for(let j=0;j<holdPlaneArray.length;j++)
      {
        if(holdPlaneArray[j][0] == ("" + arrayElements[0]))
          checkBoxIdStr += " checked";
      }
      tableHTML +=
      "<tr class = " +
      tr_className +
      "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[1] +"</td><td class = " + td_className + ">"+ (arrayElements[2] + arrayElements[3]) +"</td><td id = " + td_className + "><input type='checkbox' onclick = 'holdRowInfo(" + td_className + ", this.id)' "+ checkBoxIdStr +"></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(13)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;

  flight_airplane_get_array_clicked += 1;
  if(flight_airplane_get_array_clicked === 1){
    flightAirplaneGetArray();
  }
}
async function flightAirplaneGetArray(){
  if(flight_airplane_get_array_clicked < 2 || createFlight_clicked){
    let first_last = "";
    if(airplaneArrayFlight[0] === undefined || createFlight_clicked){
      first_last = "first";
    }
    else if(airplaneArrayFlight[0] !== undefined){
      first_last = "last";
    }
    if(flight_airplane_submit_clicked){
      first_last = "submit";
    }
    try {
      const response = await fetch('http://localhost:5001/api/flightAirplane?first_last=' + first_last + '&username=' + username + "&flightAirplaneType1Checked=" + flightAirplaneType1Checked + "&flightAirplaneType2Checked=" + flightAirplaneType2Checked + "&flightAirplaneType3Checked=" + flightAirplaneType3Checked);
      const player = await response.json();
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });

      if(airplaneArrayFlight[0] === undefined || flight_airplane_submit_clicked || createFlight_clicked){
        airplaneArrayFlight = temp;
      }
      else{
        airplaneArrayFlight = airplaneArrayFlight.concat(temp);
      }
      selectPlaneButton();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    selectPlaneButton();
  }
}

//Show Flight
function showFlight() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );

  let tableHTML =
    '<button class = "previousButton" onclick="preButton(14)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Date</th><th>Details</th></tr>';

  for (let i = 0; i < 8; i++) {
    let tr_className = "tr_showFlight_" + i;
    let td_className = "td_showFlight_" + i;
    let arrayElements = flightArrayShow[(i) + (currentPageShowFlight * 8)];

    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      tr_className +
      '><td></td><td></td><td></td></tr>';
    }
    else
    {
      tableHTML +=
            "<tr class = " +
            tr_className +
            "><td class = " + td_className + ">"+ arrayElements[0] +"</td><td class = " + td_className + ">"+ arrayElements[13] +"</td><td id = " + td_className + " onclick = 'holdRowInfo(" + td_className + ", this.id);'></td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(14)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;

  flight_show_get_array_clicked += 1;
  if(flight_show_get_array_clicked === 1){
    getShowFlightArray();
  }
}
async function getShowFlightArray(){
  if(flight_show_get_array_clicked < 2){
    let first_last = "";
    if(flightArrayShow[0] === undefined){
      first_last = "first";
    }
    else if(flightArrayShow[0] !== undefined){
      first_last = "last";
    }
    if(flight_show_submit_clicked){
      first_last = "submit";
    }

    try {
      const response = await fetch('http://localhost:5001/api/flightShow?first_last=' + first_last + '&username=' + username + "&flightShowFilterMaxDate=" + flightShowFilterMaxDate + "&flightShowFilterMinDate=" + flightShowFilterMinDate + "&flightShowFilterMaxId=" + flightShowFilterMaxId + "&flightShowFilterMinId=" + flightShowFilterMinId);
      const player = await response.json();
      let temp = [];
      player.forEach(row => {
        const rowArray = Object.values(row);
        temp.push(rowArray);
      });

      if(flightArrayShow[0] === undefined || flight_show_submit_clicked){
        flightArrayShow = temp;
      }
      else{
        flightArrayShow = flightArrayShow.concat(temp);
      }
      showFlight();
    } catch {
      return alert('ERROR')
    }
  }
  else{
    showFlight();
  }
}

//Show Details
function showDetails() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );

  let innerHTML =
    '<button onclick="routeButton()">Route</button><button onclick="crewButton()">Crew</button><button onclick="filterPassenger(); passangerButton();">Passanger</button><button onclick="planeButton()">Plane</button>';
  flight_action.innerHTML = innerHTML;

  flight_action.style.cssText =
    "display: flex;flex: 8;  width: 90%; height: 60%; justify-content: space-between;  align-items: center;";
  let flight_action_buttons = document.querySelectorAll(
    "section .action .flight-action button"
  );

  flight_action_buttons.forEach(function (button) {
    button.style.cssText = "width: 22%; height: 60%;";
  });
  getShowDetailsArray();
} 

async function getShowDetailsArray(){
  try {
    const response = await fetch('http://localhost:5001/api/flightDetails?id=' + showFlightDetailsID);
    const player = await response.json();

    let temp = [];
    player.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
    });

    try {
      const response = await fetch('http://localhost:5001/api/getAirportDetails?id=' + temp[0][2] + "," + temp[0][3]);
      const player1 = await response.json();
      let temp1 = [];
      player1.forEach(row => {
        const rowArray = Object.values(row);
        temp1.push(rowArray);
      });
      route_details = temp1;

      pilot_details = [];
      cabin_attendant_details = [];
      passenger_details = [];
      plane_details = "";
      
    } catch {
      return alert('ERROR')
    }
    try {
      const response = await fetch('http://localhost:5001/api/getPilotsDetails?id=' + temp[0][4] + "," + temp[0][5] + "," + temp[0][6]);
      const player2 = await response.json();
      let temp2 = [];
      player2.forEach(row => {
        const rowArray = Object.values(row);
        temp2.push(rowArray);
      });
      pilot_details = temp2;
      
    } catch {
      return alert('ERROR')
    }

    try {
      const response = await fetch('http://localhost:5001/api/getCabinAttendantsDetails?id=' + temp[0][7] + "," + temp[0][8] + "," + temp[0][9] + "," + temp[0][10] + "," + temp[0][11]);
      const player3 = await response.json();
      let temp3 = [];
      player3.forEach(row => {
        const rowArray = Object.values(row);
        temp3.push(rowArray);
      });
      cabin_attendant_details = temp3;
      
    } catch {
      return alert('ERROR')
    }

    try {
      const response = await fetch('http://localhost:5001/api/getPassangersDetails?id=' + temp[0][0] +"&passengerFilterNameValue=" + passengerFilterNameValue + "&passengerFilterGenderValue=" + passengerFilterGenderValue);
      const player4 = await response.json();
      let temp4 = [];
      player4.forEach(row => {
        const rowArray = Object.values(row);
        temp4.push(rowArray);
      });
      passenger_details = temp4;
      if(passenger_submit_clicked){
        passangerButton();
        passenger_submit_clicked = false;
      }
      
    } catch {
      return alert('ERROR')
    }

    try {
      const response = await fetch('http://localhost:5001/api/getPlaneDetails?id=' + temp[0][12]);
      const player5 = await response.json();
      let temp5 = [];
      player5.forEach(row => {
        const rowArray = Object.values(row);
        temp5.push(rowArray);
      });
      plane_details = temp5;

    } catch {
      return alert('ERROR')
    }

    try {
      const response = await fetch('http://localhost:5001/api/getPlaneOccupancyDetails?id=' + temp[0][0]);
      const player6 = await response.json();
      let temp6 = [];
      player6.forEach(row => {
        const rowArray = Object.values(row);
        temp6.push(rowArray);
        occupancy_rate = temp6[0];
      });
    } catch {
      return alert('ERROR')
    }
    } catch {
    return alert('ERROR')
    }
}

function routeButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );

  let tableHTML =
    "<table><tr><th>ID</th><th></th><th>Name</th><th>City</th><th>Country</th></tr>";

  tableHTML +=
    "<tr><td>" + route_details[0][0] + "</td><td>Take-off</td><td>" + route_details[0][1] + "</td><td>" + route_details[0][3] + "</td><td>" + route_details[0][2] + "</td></tr>";
  tableHTML +=
  "<tr><td>" + route_details[1][0] + "</td><td>Landing</td><td>" + route_details[1][1] + "</td><td>" + route_details[1][3] + "</td><td>" + route_details[1][2] + "</td></tr>";

  flight_action.innerHTML = tableHTML;
}

function crewButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );

  let flightArrayCrew = pilot_details.concat(cabin_attendant_details);
  
  
  let tableHTML =
    "<table><tr><th>ID</th><th>Name</th><th>Profession</th></tr>";

  for (let i = 0; i < 8; i++) {
    let className = "class_" + (i + 1);
    let arrayElements = flightArrayCrew[i];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      className +
      "><td></td><td></td><td></td><td></td><td></td></tr>";
    }
    else{
      tableHTML +=
      "<tr class = " +
      className +
      "><td>"+ arrayElements[0] +"</td><td>"+ arrayElements[6] + " " + arrayElements[7] +"</td><td>"+ arrayElements[3] +"</td></tr>";
    }
  }
  tableHTML += "</table>";

  flight_action.innerHTML = tableHTML;
}

function passangerButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let tableHTML =
    '<button class = "previousButton" onclick="preButton(15)"><i class="fa-solid fa-circle-arrow-left"></i></button><table><tr><th>ID</th><th>Name</th><th>Gender</th><th>Birth Date</th></tr>';

  for (let i = 0; i < 8; i++) {
    let className = "class_" + (i + 1);
    let arrayElements = passenger_details[(i) + (currentPagePassenger * 8)];
    if(arrayElements == undefined)
    {
      tableHTML +=
      "<tr class = " +
      className +
      "><td></td><td></td><td></td><td></td></tr>"
    }
    else{
      let gender = "";
      if(arrayElements[3] === 0){
        gender = "Male";
      }else{
        gender = "Female"
      }
      tableHTML +=
      "<tr class = " +
      className +
      "><td>"+ arrayElements[0] +"</td><td>"+ arrayElements[1] + " " + arrayElements[2] +"</td><td>"+ gender +"</td><td>"+ arrayElements[4].substring(0,10) +"</td></tr>";
    }
  }
  tableHTML +=
    '</table><button class="nextButton" onclick="nextButton(15)"><i class="fa-solid fa-circle-arrow-right"></i></button>';
  flight_action.innerHTML = tableHTML;
}

function planeButton() {
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );
  let capacity =  parseInt(plane_details[0][4]) +  parseInt(plane_details[0][3]);
  let tableHTML =
    "<table><tr><th>ID</th><th>Type</th><th>Occupancy Rate</th><th>Flight Count</th></tr>";

  tableHTML += "<td>"+ plane_details[0][0] +"</td><td>"+ plane_details[0][1] +"</td><td>" + (parseFloat(occupancy_rate) / capacity) * 100.0 + "</td><td>"+ plane_details[0][2] +"</td></table>";
  flight_action.innerHTML = tableHTML;
}

function backFlight() {
  rewriteOptions();
  let flight_action = document.querySelector(
    "section .action .flight-action"
  );

  let flight_action_inner_HTML = String(flight_action.innerHTML);

  if (
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Date") &&
      flight_action_inner_HTML.includes("Details")) ||
    (flight_action_inner_HTML.includes("Take-off") &&
      flight_action_inner_HTML.includes("Landing") &&
      flight_action_inner_HTML.includes("Pilot") &&
      flight_action_inner_HTML.includes("Cabin Attendant") &&
      flight_action_inner_HTML.includes("Plane"))
  ) {
    openFlightOptions();
  } else if (
    flight_action_inner_HTML.includes("Route") &&
    flight_action_inner_HTML.includes("Crew") &&
    flight_action_inner_HTML.includes("Passanger") &&
    flight_action_inner_HTML.includes("Plane")
  ) {
    showFlight();
  } else if (
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Name") &&
      flight_action_inner_HTML.includes("City") &&
      flight_action_inner_HTML.includes("Country") &&
      !flight_action_inner_HTML.includes("Select")) ||
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Name") &&
      flight_action_inner_HTML.includes("Profession")) ||
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Name") &&
      flight_action_inner_HTML.includes("Gender") &&
      flight_action_inner_HTML.includes("Birth Date")) ||
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Type") &&
      flight_action_inner_HTML.includes("Occupancy Rate") &&
      flight_action_inner_HTML.includes("Flight Count"))
  ) {
    showDetails();
  } else if (
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Name") &&
      flight_action_inner_HTML.includes("City") &&
      flight_action_inner_HTML.includes("Country") &&
      flight_action_inner_HTML.includes("Select")) ||
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Name") &&
      flight_action_inner_HTML.includes("Experience") &&
      flight_action_inner_HTML.includes("Select") &&
      !flight_action_inner_HTML.includes("Profession")) ||
    (flight_action_inner_HTML.includes("ID") &&
      flight_action_inner_HTML.includes("Type") &&
      flight_action_inner_HTML.includes("Capacity") &&
      flight_action_inner_HTML.includes("Select"))
  ) {
    generateFlight();
  }
  else{
    back();
  }
}

//bank
function openBankOptions() {
  let action_div = document.querySelector("section .action");
  let class1 = "bank-options";
  let class2 = "bank-action";
  action_div.innerHTML =
    "<div class=" + class1 + "></div><div class=" + class2 + "></div>";

  let bank_options = document.querySelector(
    "section .action .bank-options"
  );

  bank_options.innerHTML =
    '<button onclick="loan()">Take Out Loan</button><button onclick="back()">Back</button>';
}

function loan() {
  let bank_action = document.querySelector(
    "section .action .bank-action"
  );
  let innerHTML =
    '<button onclick="lowLoan()">300,000$<br>%15 Interest Rate<br>11,500$<br>30 Days</button><button onclick="midLoan()">500,000$<br>%25 Interest Rate<br>15,625$<br>40 Days</button><button onclick="highLoan()">700,000$<br>%40 Interest Rate<br>19,600$<br>50 Days</button>';
  bank_action.innerHTML = innerHTML;

  bank_action.style.cssText =
    "display: flex;flex: 8;  width: 90%; height: 60%; justify-content: space-between;  align-items: center;";
  let bank_action_buttons = document.querySelectorAll(
    "section .action .bank-action button"
  );

  bank_action_buttons.forEach(function (button) {
    if(active_credit_amount === 0){
      button.style.cssText = "width: 22%; height: 60%; background-color: #35b000; color: white;";
    }
    else{
      button.style.cssText = "width: 22%; height: 60%; background-color: #ff4242; color: white;";
    }
  });
}
async function lowLoan(){
  if(active_credit_amount === 0){
    const response = await fetch('http://localhost:5001/api/loan?username=' + username + "&credit_amount=300000&day=30");
    financial_turnover += 300000;
    active_credit_amount = 300000;
  }else{
    alert("You already have a loan!")
  }
  loan();
}
async function midLoan(){
  if(active_credit_amount === 0){
    const response = await fetch('http://localhost:5001/api/loan?username=' + username + "&credit_amount=500000&day=40");
    financial_turnover += 500000;
    active_credit_amount = 500000;
  }else{
    alert("You already have a loan!")
  }
  loan();
}
async function highLoan(){
  if(active_credit_amount === 0){
    const response = await fetch('http://localhost:5001/api/loan?username=' + username + "&credit_amount=700000&day=50");
    financial_turnover += 700000;
    active_credit_amount = 700000;
  }else{
    alert("You already have a loan!")
  }
  loan();
}


async function exit() {
  try {
    const response = await fetch('http://localhost:5001/api/playerOffline?username=' + username);
    const player = await response.json();
    if(player.exists){
      window.location.href = "/index";
    }
  } catch {
    return alert('ERROR')
  }
}

function back() {
  let action_div = document.querySelector("section .action");
  action_div.innerHTML = "";
  clearRightSide();
}


//Filtering
function filterHireEmp(){
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label for="name">Name:</label><input type="text" id="name" name="name"><br><label for="experience">Experience:</label><br><select name="experience" id="experience"><option value="entry">Entry Level</option><option value="mid">Mid Level</option><option value="senior">Senior Level</option></select><br><label>Profession:</label><br><label for="all">All</label><input type="radio" id="all" name="profession" value="all" checked><label for="pilot">Pilot</label><input type="radio" id="pilot" name="profession" value="pilot"><label for="cabinAttendant">Cabin Attendant</label><input type="radio" id="cabinAttendant" name="profession" value="cabinAttendant"><br><button type="submit" onclick="hireFilterHold();">Submit</button><br><button type="clearButton" onclick="clearHireFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function hireFilterHold()
{
  hire_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let selectedProfession = document.querySelector('input[name="profession"]:checked');
  let selectedExperience = document.getElementById('experience');
  let stringForFlightCount = getMaxMinFlight(selectedExperience.value);
  if(nameInput.value === ""){
    hireFilterNameValue = "?";
  }
  else{
    hireFilterNameValue = nameInput.value;
  }
  if(selectedProfession.value === "all"){
    hireFilterProfessionValue = "?";
  }
  else if(selectedProfession.value === "cabinAttendant"){
    hireFilterProfessionValue = "cabin attendant";
  }
  else if(selectedProfession.value === "pilot"){
    hireFilterProfessionValue = "pilot";
  }
  hireFilterMinFlightCount = stringForFlightCount.split(",")[0]; 
  hireFilterMaxFlightCount = stringForFlightCount.split(",")[1]; 
  hire_get_array_clicked = 1;
  currentPageHire = 0;
  hireGetArray();
}
function clearHireFilter (){
  hire_submit_clicked = false;
  hire_get_array_clicked = 0;
  hireFilterNameValue = "?";
  hireFilterMinFlightCount = "-1"; 
  hireFilterMaxFlightCount = "-1"; 
  hireFilterProfessionValue = "?";
  employeeArrayHire = [];
  hireGetArray();
}


function filterDismissEmp()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><input type="text" id="name" name="name"><br><label for="experience">Experience:</label><br><select name="experience" id="experience"><option value="entry">Entry Level</option><option value="mid">Mid Level</option><option value="senior">Senior Level</option></select><br><label>Profession:</label><br><label for="all">All</label><input type="radio" id="all" name="profession" value="all" checked><label for="pilot">Pilot</label><input type="radio" id="pilot" name="profession" value="pilot"><label for="cabinAttendant">Cabin Attendant</label><input type="radio" id="cabinAttendant" name="profession" value="cabinAttendant"><br><button type="submit" onclick="dismissFilterHold();">Submit</button><br></button><br><button type="clearButton" onclick="clearDismissFilter();">Clear Filter</button>';
  optionsBar.innerHTML = optionHTML1;
}
function dismissFilterHold()
{
  dismiss_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let selectedProfession = document.querySelector('input[name="profession"]:checked');
  let selectedExperience = document.getElementById('experience');
  let stringForFlightCount = getMaxMinFlight(selectedExperience.value);

  if(nameInput.value === ""){
    dismissFilterNameValue = "?";
  }
  else{
    dismissFilterNameValue = nameInput.value;
  }
  if(selectedProfession.value === "all"){
    dismissFilterProfessionValue = "?";
  }
  else if(selectedProfession.value === "cabinAttendant"){
    dismissFilterProfessionValue = "cabin attendant";
  }
  else if(selectedProfession.value === "pilot"){
    dismissFilterProfessionValue = "pilot";
  }
  dismissFilterMinFlightCount = stringForFlightCount.split(",")[0]; 
  dismissFilterMaxFlightCount = stringForFlightCount.split(",")[1]; 
  dismiss_get_array_clicked = 1;
  currentPageDismiss = 0;
  dismissGetArray();
}
function clearDismissFilter (){
  dismiss_submit_clicked = false;
  dismiss_get_array_clicked = 0;
  dismissFilterNameValue = "?";
  dismissFilterMinFlightCount = "-1"; 
  dismissFilterMaxFlightCount = "-1"; 
  dismissFilterProfessionValue = "?";
  employeeArrayDismiss = [];
  dismissGetArray();
}


function filterShowEmp()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><input type="text" id="name" name="name"><br><label for="experience">Experience:</label><br><select name="experience" id="experience"><option value="entry">Entry Level</option><option value="mid">Mid Level</option><option value="senior">Senior Level</option></select><br><label>Profession:</label><br><label for="all">All</label><input type="radio" id="all" name="profession" value="all" checked><label for="pilot">Pilot</label><input type="radio" id="pilot" name="profession" value="pilot"><label for="cabinAttendant">Cabin Attendant</label><input type="radio" id="cabinAttendant" name="profession" value="cabinAttendant"><br><button type="submit" onclick="showEmpFilterHold()">Submit</button><br><button type="clearButton" onclick="clearShowFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function showEmpFilterHold()
{
  show_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let selectedProfession = document.querySelector('input[name="profession"]:checked');
  let selectedExperience = document.getElementById('experience');
  let stringForFlightCount = getMaxMinFlight(selectedExperience.value);

  if(nameInput.value === ""){
    showFilterNameValue = "?";
  }
  else{
    showFilterNameValue = nameInput.value;
  }

  if(selectedProfession.value === "all"){
    showFilterProfessionValue = "?";
  }
  else if(selectedProfession.value === "cabinAttendant"){
    showFilterProfessionValue = "cabin attendant";
  }
  else if(selectedProfession.value === "pilot"){
    showFilterProfessionValue = "pilot";
  }
  showFilterMinFlightCount = stringForFlightCount.split(",")[0]; 
  showFilterMaxFlightCount = stringForFlightCount.split(",")[1]; 
  show_get_array_clicked = 1;
  currentPageShow = 0;
  showGetArray();
}
function clearShowFilter (){
  show_submit_clicked = false;
  show_get_array_clicked = 0;
  showFilterNameValue = "?";
  showFilterMinFlightCount = "-1"; 
  showFilterMaxFlightCount = "-1"; 
  showFilterProfessionValue = "?";
  employeeArrayShow = [];
  showGetArray();
}


function filterBuyAirplane()
{
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label>Type:</label><br><label><input type="checkbox" id="type1Checkbox"> DEU-AIRLINES-A200</label><br><label><input type="checkbox" id="type2Checkbox"> DEU-AIRLINES-A300</label><br><label><input type="checkbox" id="type3Checkbox"> DEU-AIRLINES-A400</label><br><button type="submit" onclick="buyAirplaneFilterHold()">Submit</button><br><button type="clearButton" onclick="clearBuyAirplaneFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function buyAirplaneFilterHold()
{
  buy_airplane_submit_clicked = true;
  let type1Checkbox = document.getElementById('type1Checkbox');
  let type2Checkbox = document.getElementById('type2Checkbox');
  let type3Checkbox = document.getElementById('type3Checkbox');
  
  buyAirplaneType1Checked = type1Checkbox.checked;
  buyAirplaneType2Checked = type2Checkbox.checked;
  buyAirplaneType3Checked = type3Checkbox.checked;

  buy_airplane_get_array_clicked = 1;
  currentPageBuyAirplane = 0;
  buyAirplaneGetArray();
}
function clearBuyAirplaneFilter (){
  buy_airplane_submit_clicked = false;
  buy_airplane_get_array_clicked = 0;
  buyAirplaneType1Checked = "false";
  buyAirplaneType2Checked = "false";
  buyAirplaneType3Checked = "false";
  airplaneArrayBuy = [];
  buyAirplaneGetArray();
}


function filterSellAirplane()
{
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label>Type:</label><br><label><input type="checkbox" id="type1Checkbox"> DEU-AIRLINES-A200</label><br><label><input type="checkbox" id="type2Checkbox"> DEU-AIRLINES-A300</label><br><label><input type="checkbox" id="type3Checkbox"> DEU-AIRLINES-A400</label><br><button type="submit" onclick="sellAirplaneFilterHold()">Submit</button><br><button type="clearButton" onclick="clearSellAirplaneFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function sellAirplaneFilterHold()
{
  sell_airplane_submit_clicked = true;
  let type1Checkbox = document.getElementById('type1Checkbox');
  let type2Checkbox = document.getElementById('type2Checkbox');
  let type3Checkbox = document.getElementById('type3Checkbox');
  
  sellAirplaneType1Checked = type1Checkbox.checked;
  sellAirplaneType2Checked = type2Checkbox.checked;
  sellAirplaneType3Checked = type3Checkbox.checked;

  sell_airplane_get_array_clicked = 1;
  currentPageSellAirplane = 0;
  sellAirplaneGetArray();
}
function clearSellAirplaneFilter (){
  sell_airplane_submit_clicked = false;
  sell_airplane_get_array_clicked = 0;
  sellAirplaneType2Checked = "false";
  sellAirplaneType3Checked = "false";
  airplaneArraySell = [];
  sellAirplaneGetArray();
}


function filterShowAirplane()
{
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label>Type:</label><br><label><input type="checkbox" id="type1Checkbox"> DEU-AIRLINES-A200</label><br><label><input type="checkbox" id="type2Checkbox"> DEU-AIRLINES-A300</label><br><label><input type="checkbox" id="type3Checkbox"> DEU-AIRLINES-A400</label><br><button type="submit" onclick="showAirplaneFilterHold()">Submit</button><br><button type="clearButton" onclick="clearShowAirplaneFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function showAirplaneFilterHold()
{
  show_airplane_submit_clicked = true;
  let type1Checkbox = document.getElementById('type1Checkbox');
  let type2Checkbox = document.getElementById('type2Checkbox');
  let type3Checkbox = document.getElementById('type3Checkbox');
  
  showAirplaneType1Checked = type1Checkbox.checked;
  showAirplaneType2Checked = type2Checkbox.checked;
  showAirplaneType3Checked = type3Checkbox.checked;

  show_airplane_get_array_clicked = 1;
  currentPageShowAirplane = 0;
  showAirplaneGetArray();
}
function clearShowAirplaneFilter (){
  show_airplane_submit_clicked = false;
  show_airplane_get_array_clicked = 0;
  showAirplaneType1Checked = "false";
  showAirplaneType2Checked = "false";
  showAirplaneType3Checked = "false";
  airplaneArrayShow = [];
  showAirplaneGetArray();
}


function filterUnlockAirport()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><br><input type="text" id="name" name="name"><br><label for="city">City:</label><br><input type="text" id="city" name="city"><br><label for="country">Country:</label><br><input type="text" id="country" name="country"><br><button type="submit" onclick="unlockFilterHold()">Submit</button><br><button type="clearButton" onclick="clearUnlockAirportFilter();">Clear Filter</button>';
  optionsBar.innerHTML = optionHTML1;
}
function unlockFilterHold() {       
  unlock_airport_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let cityInput = document.getElementById('city');
  let countryInput = document.getElementById('country');

  if(nameInput.value === ""){
    unlockFilterNameValue = "?";
  }
  else{
    unlockFilterNameValue = nameInput.value;
  }
  if(cityInput.value === ""){
    unlockFilterCityValue = "?";
  }
  else{
    unlockFilterCityValue = cityInput.value;;
  }
  if(countryInput.value === ""){
    unlockFilterCountryValue = "?";
  }
  else{
    unlockFilterCountryValue = countryInput.value;
  }

  unlock_airport_get_array_clicked = 1;
  currentPageUnlockAirport = 0;
  unlockAirportGetArray();

}
function clearUnlockAirportFilter (){
  unlock_airport_submit_clicked = false;
  unlock_airport_get_array_clicked = 0;
  unlockFilterNameValue = "?";
  unlockFilterCityValue = "?";
  unlockFilterCountryValue = "?";
  airportArrayUnlock = [];
  unlockAirportGetArray();
}


function filterShowAirport()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><br><input type="text" id="name" name="name"><br><label for="city">City:</label><br><input type="text" id="city" name="city"><br><label for="country">Country:</label><br><input type="text" id="country" name="country"><br><button type="submit" onclick="showAirportFilterHold()">Submit</button><br><button type="clearButton" onclick="clearShowAirportFilter();">Clear Filter</button>';
  optionsBar.innerHTML = optionHTML1;
}
function showAirportFilterHold()
{
  show_airport_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let cityInput = document.getElementById('city');
  let countryInput = document.getElementById('country');

  if(nameInput.value === ""){
    showAirportFilterNameValue = "?";
  }
  else{
    showAirportFilterNameValue = nameInput.value;
  }
  if(cityInput.value === ""){
    showAirportFilterCityValue = "?";
  }
  else{
    showAirportFilterCityValue = cityInput.value;;
  }
  if(countryInput.value === ""){
    showAirportFilterCountryValue = "?";
  }
  else{
    showAirportFilterCountryValue = countryInput.value;
  }

  show_airport_get_array_clicked = 1;
  currentPageShowAirport = 0;
  showAirportGetArray();
}
function clearShowAirportFilter (){
  show_airport_submit_clicked = false;
  show_airport_get_array_clicked = 0;
  showAirportFilterNameValue = "?";
  showAirportFilterCityValue = "?";
  showAirportFilterCountryValue = "?";
  airportArrayShow = [];
  showAirportGetArray();
}


function filterTakeoff()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><br><input type="text" id="name" name="name"><br><label for="city">City:</label><br><input type="text" id="city" name="city"><br><label for="country">Country:</label><br><input type="text" id="country" name="country"><br><button type="submit" onclick="takeoffFilterHold()">Submit</button><br><button type="clearButton" onclick="clearTakeOffFlightFilter();">Clear Filter</button>';
  optionsBar.innerHTML = optionHTML1;
}
function takeoffFilterHold()
{
  take_off_airport_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let cityInput = document.getElementById('city');
  let countryInput = document.getElementById('country');

  if(nameInput.value === ""){
    takeOffFilterNameValue = "?";
  }
  else{
    takeOffFilterNameValue = nameInput.value;
  }
  if(cityInput.value === ""){
    takeOffFilterCityValue = "?";
  }
  else{
    takeOffFilterCityValue = cityInput.value;;
  }
  if(countryInput.value === ""){
    takeOffFilterCountryValue = "?";
  }
  else{
    takeOffFilterCountryValue = countryInput.value;
  }

  take_off_airport_get_array_clicked = 1;
  currentPageTakeOff = 0;
  getTakeOffArray();
}
function clearTakeOffFlightFilter (){
  take_off_airport_submit_clicked = false;
  take_off_airport_get_array_clicked = 0;
  takeOffFilterNameValue = "?";
  takeOffFilterCityValue = "?";
  takeOffFilterCountryValue = "?";
  flightArrayTakeOff = [];
  getTakeOffArray();
}


function filterLanding()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><br><input type="text" id="name" name="name"><br><label for="city">City:</label><br><input type="text" id="city" name="city"><br><label for="country">Country:</label><br><input type="text" id="country" name="country"><br><button type="submit" onclick="landingFilterHold()">Submit</button><br><button type="clearButton" onclick="clearLandingFlightFilter();">Clear Filter</button>';
  optionsBar.innerHTML = optionHTML1;
}
function landingFilterHold()
{
  landing_airport_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let cityInput = document.getElementById('city');
  let countryInput = document.getElementById('country');

  if(nameInput.value === ""){
    landingFilterNameValue = "?";
  }
  else{
    landingFilterNameValue = nameInput.value;
  }
  if(cityInput.value === ""){
    landingFilterCityValue = "?";
  }
  else{
    landingFilterCityValue = cityInput.value;;
  }
  if(countryInput.value === ""){
    landingFilterCountryValue = "?";
  }
  else{
    landingFilterCountryValue = countryInput.value;
  }

  landing_airport_get_array_clicked = 1;
  currentPageLanding = 0;
  getLandingArray();
}
function clearLandingFlightFilter (){
  landing_airport_submit_clicked = false;
  landing_airport_get_array_clicked = 0;
  landingFilterNameValue = "?";
  landingFilterCityValue = "?";
  landingFilterCountryValue = "?";
  flightArrayLanding = [];
  getLandingArray();
}


function filterPilot()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><input type="text" id="name" name="name"><br><label for="experience">Experience:</label><br><select name="experience" id="experience"><option value="entry">Entry Level</option><option value="mid">Mid Level</option><option value="senior">Senior Level</option></select><br><button type="submit" onclick="pilotFilterHold()">Submit</button><br><button type="clearButton" onclick="clearPilotFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function pilotFilterHold()
{
  pilot_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let selectedExperience = document.getElementById('experience');
  let stringForFlightCount = getMaxMinFlight(selectedExperience.value);

  if(nameInput.value === ""){
    pilotFilterNameValue = "?";
  }
  else{
    pilotFilterNameValue = nameInput.value;
  }

  pilotFilterMinFlightCount = stringForFlightCount.split(",")[0]; 
  pilotFilterMaxFlightCount = stringForFlightCount.split(",")[1]; 
  pilot_get_array_clicked = 1;
  currentPagePilot = 0;
  getPilotArray();
}
function clearPilotFilter (){
  pilot_submit_clicked = false;
  pilot_get_array_clicked = 0;
  pilotFilterNameValue = "?";
  pilotFilterMinFlightCount = "-1"; 
  pilotFilterMaxFlightCount = "-1"; 
  flightArrayPilot = [];
  getPilotArray();
}


function filterCabinAttendant()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="name">Name:</label><input type="text" id="name" name="name"><br><label for="experience">Experience:</label><br><select name="experience" id="experience"><option value="entry">Entry Level</option><option value="mid">Mid Level</option><option value="senior">Senior Level</option></select><br><button type="submit" onclick="cabinAttendantFilterHold()">Submit</button><br><button type="clearButton" onclick="clearCabinAttendantFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function cabinAttendantFilterHold()
{
  cabin_attendant_submit_clicked = true;
  let nameInput = document.getElementById('name');
  let selectedExperience = document.getElementById('experience');
  let stringForFlightCount = getMaxMinFlight(selectedExperience.value);

  if(nameInput.value === ""){
    cabinAttendantFilterNameValue = "?";
  }
  else{
    cabinAttendantFilterNameValue = nameInput.value;
  }

  cabinAttendantFilterMinFlightCount = stringForFlightCount.split(",")[0]; 
  cabinAttendantFilterMaxFlightCount = stringForFlightCount.split(",")[1]; 
  cabin_attendant_get_array_clicked = 1;
  currentPageCabinAttendant = 0;
  getCabinAttendantArray();
}
function clearCabinAttendantFilter (){
  cabin_attendant_submit_clicked = false;
  cabin_attendant_get_array_clicked = 0;
  cabinAttendantFilterNameValue = "?";
  cabinAttendantFilterMinFlightCount = "-1"; 
  cabinAttendantFilterMaxFlightCount = "-1"; 
  flightArrayCabinAttendant = [];
  getCabinAttendantArray();
}


function filterFlightAirplane()
{
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label>Type:</label><br><label><input type="checkbox" id="type1Checkbox"> DEU-AIRLINES-A200</label><br><label><input type="checkbox" id="type2Checkbox"> DEU-AIRLINES-A300</label><br><label><input type="checkbox" id="type3Checkbox"> DEU-AIRLINES-A400</label><br><button type="submit" onclick="flightAirplaneFilterHold()">Submit</button><br><button type="clearButton" onclick="clearFlightAirplaneFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function flightAirplaneFilterHold()
{
  flight_airplane_submit_clicked = true;
  let type1Checkbox = document.getElementById('type1Checkbox');
  let type2Checkbox = document.getElementById('type2Checkbox');
  let type3Checkbox = document.getElementById('type3Checkbox');
  
  flightAirplaneType1Checked = type1Checkbox.checked;
  flightAirplaneType2Checked = type2Checkbox.checked;
  flightAirplaneType3Checked = type3Checkbox.checked;

  flight_airplane_get_array_clicked = 1;
  currentPageFlightAirplane = 0;
  flightAirplaneGetArray();
}
function clearFlightAirplaneFilter (){
  flight_airplane_submit_clicked = false;
  flight_airplane_get_array_clicked = 0;
  flightAirplaneType1Checked = "false";
  flightAirplaneType2Checked = "false";
  flightAirplaneType3Checked = "false";
  airplaneArrayFlight = [];
  flightAirplaneGetArray();
}

function filterFlightShow()
{
  let optionsBar = document.querySelector(
    "section .options"
  );

  optionHTML1 = '<label for="min_id">Min ID:</label><input type="number" id="min_id" name="min_id"><br><label for="max_id">Max ID:</label><input type="number" id="max_id" name="max_id"><br><label for="min_date">Min Date:</label><input type="number" id="min_date" name="min_date"><br><label for="max_date">Max Date:</label><input type="number" id="max_date" name="max_date"><br></select><br><button type="submit" onclick="flightShowFilterHold()">Submit</button><br><button type="clearButton" onclick="clearFlightShowFilter();">Clear Filter</button>';

  optionsBar.innerHTML = optionHTML1;
}
function flightShowFilterHold()
{
  flight_show_submit_clicked = true;
  let min_id = document.getElementById('min_id');
  let max_id = document.getElementById('max_id');
  let min_date = document.getElementById('min_date');
  let max_date = document.getElementById('max_date');
  
  if(min_id.value === ""){
    flightShowFilterMinId = "-1";
  }
  else{
    flightShowFilterMinId = min_id.value;
  }
  if(max_id.value === ""){
    flightShowFilterMaxId = "-1";
  }
  else{
    flightShowFilterMaxId = max_id.value;
  }
  if(min_date.value === ""){
    flightShowFilterMinDate = "-1";
  }
  else{
    flightShowFilterMinDate = min_date.value;
  }
  if(max_date.value === ""){
    flightShowFilterMaxDate = "-1";
  }
  else{
    flightShowFilterMaxDate = max_date.value;
  }

  flight_show_get_array_clicked = 1;
  currentPageShowFlight = 0;
  getShowFlightArray();
}
function clearFlightShowFilter (){
  flight_show_submit_clicked = false;
  flight_show_get_array_clicked = 0;
  currentPageShowFlight = 0;
  flightShowFilterMaxDate = "-1";
  flightShowFilterMinDate = "-1";
  flightShowFilterMaxId = "-1";
  flightShowFilterMinId = "-1";
  flightArrayShow = [];
  getShowFlightArray();
}


function filterPassenger()
{
  let optionsBar = document.querySelector(
    "section .options"
  );
  optionHTML1 = '<label for="namePassenger">Name:</label><br><input type="text" id="namePassenger" name="namePassenger"><br><label>Gender:</label><br><label for="allPassenger">All</label><input type="radio" id="allPassenger" name="genderPassenger" value="allPassenger" checked><label for="malePassenger">Male</label><input type="radio" id="malePassenger" name="genderPassenger" value="malePassenger"><label for="femalePassenger">Female</label><input type="radio" id="femalePassenger" name="genderPassenger" value="femalePassenger"><br><button type="submit" onclick="passengerFilterHold()">Submit</button><button type="clear" onclick="clearPassengerFilterHold()">Clear</button>';
  optionsBar.innerHTML = optionHTML1;
}
function passengerFilterHold()
{
  passenger_submit_clicked = true;
  let nameInput = document.getElementById('namePassenger');
  let selectedGender = document.querySelector('input[name="genderPassenger"]:checked');

  if(nameInput.value === ""){
    passengerFilterNameValue = "?";
  }
  else{
    passengerFilterNameValue = nameInput.value;
  }
  if(selectedGender.value === "allPassenger"){
    passengerFilterGenderValue = "?";
  }
  else if(selectedGender.value === "femalePassenger"){
    passengerFilterGenderValue = "1";
  }
  else if(selectedGender.value === "malePassenger"){
    passengerFilterGenderValue = "0";
  }
  passenger_submit_clicked = 1;
  currentPagePassenger = 0;
  getShowDetailsArray();
  passengerButton();
  passengerButton();
}
function clearPassengerFilterHold(){
  currentPagePassenger = 0;
  passenger_submit_clicked = 1;
  passenger_get_array_clicked = 0;
  passengerFilterNameValue = "?"; 
  passengerFilterGenderValue = "?";
  passenger_details = [];
  getShowDetailsArray();

}

//Next-Pre Buttons
function rewriteOptions()
{
  let optionsBar = document.querySelector(
  "section .options"
  );

  optionHTML1 = '<button onclick="openEmployeeOptions()">Employee</button><button onclick="openAirplaneOptions()">Plane</button><button onclick="openAirportOptions()">Airport</button><button onclick="openFlightOptions()">Flight</button><button onclick="openBankOptions()">Bank</button>'

  optionsBar.innerHTML = optionHTML1;
}

function nextButton(type) {
  if(type == 1 && (employeeArrayHire.length/9)-1 > currentPageHire)
  {
    currentPageHire++;
    hireEmployee();
  }
  else if(type == 2 && (employeeArrayDismiss.length/9)-1 > currentPageDismiss)
  {
    currentPageDismiss++;
    dismissalEmployee();
  }
  else if(type == 3 && (employeeArrayShow.length/9)-1 > currentPageShow)
  {
    currentPageShow++;
    showEmployee();
  }
  else if(type == 4 && (airplaneArrayBuy.length/9)-1 > currentPageBuyAirplane)
  {
    currentPageBuyAirplane++;
    buyAirplane();
  }
  else if(type == 5 && (airplaneArraySell.length/9)-1 > currentPageSellAirplane)
  {
    currentPageSellAirplane++;
    sellAirplane();
  }
  else if(type == 6 && (airplaneArraySell.length/9)-1 > currentPageShowAirplane)
  {
    currentPageShowAirplane++;
    showAirplane();
  }
  else if(type == 7 && (airportArrayUnlock.length/9)-1 > currentPageUnlockAirport)
  {
    currentPageUnlockAirport++;
    unlockAirport();
  }
  else if(type == 8 && (airportArrayShow.length/9)-1 > currentPageShowAirport)
  {
    currentPageShowAirport++;
    showAirport();
  }
  else if(type == 9 && (flightArrayTakeOff.length/8)-1 > currentPageTakeOff)
  {
    currentPageTakeOff++;
    takeOffButton();
  }
  else if(type == 10 && (flightArrayLanding.length/8)-1 > currentPageLanding)
  {
    currentPageLanding++;
    landingButton();
  }
  else if(type == 11 && (flightArrayPilot.length/8)-1 > currentPagePilot)
  {
    currentPagePilot++;
    pilotButton();
  }
  else if(type == 12 && (flightArrayCabinAttendant.length/8)-1 > currentPageCabinAttendant)
  {
    currentPageCabinAttendant++;
    cabinAttendantButton();
  }
  else if(type == 13 && (airplaneArrayFlight.length/8)-1 > currentPageFlightAirplane)
  {
    currentPageFlightAirplane++;
    selectPlaneButton();
  }
  else if(type == 14 && (flightArrayShow.length/8)-1 > currentPageShowFlight)
  {
    currentPageShowFlight++;
    showFlight();
  }
  else if(type == 15 && (passenger_details.length/8)-1 > currentPagePassenger)
  {
    currentPagePassenger++;
    passangerButton();
  }
}
function preButton(type) {
  if(type == 1 && currentPageHire > 0)
  {
    currentPageHire--;
    hireEmployee();
  }
  else if(type == 2 && currentPageDismiss > 0){
    currentPageDismiss--;
    dismissalEmployee();
  }
  else if(type == 3 && currentPageShow > 0)
  {
    currentPageShow--;
    showEmployee();
  }
  else if(type == 4 && currentPageBuyAirplane > 0)
  {
    currentPageBuyAirplane--;
    buyAirplane();
  }
  else if(type == 5 && currentPageSellAirplane > 0)
  {
    currentPageSellAirplane--;
    sellAirplane();
  }
  else if(type == 6 && currentPageShowAirplane > 0)
  {
    currentPageShowAirplane--;
    showAirplane();
  }
  else if(type == 7 && currentPageUnlockAirport > 0)
  {
    currentPageUnlockAirport--;
    unlockAirport();
  }
  else if(type == 8 && currentPageShowAirport > 0)
  {
    currentPageShowAirport--;
    showAirport();
  }
  else if(type == 9 && currentPageTakeOff > 0)
  {
    currentPageTakeOff--;
    takeOffButton();
  }
  else if(type == 10 && currentPageLanding > 0)
  {
    currentPageLanding--;
    landingButton();
  }
  else if(type == 11 && currentPagePilot > 0)
  {
    currentPagePilot--;
    pilotButton();
  }
  else if(type == 12 && currentPageCabinAttendant > 0)
  {
    currentPageCabinAttendant--;
    cabinAttendantButton();
  }
  else if(type == 13 && currentPageFlightAirplane > 0)
  {
    currentPageFlightAirplane--;
    selectPlaneButton();
  }
  else if(type == 14 && currentPageShowFlight > 0)
  {
    currentPageShowFlight--;
    showFlight();
  }
  else if(type == 15 && currentPagePassenger > 0)
  {
    currentPagePassenger--;
    passangerButton();
  }
}


//Holding table row
function holdRowInfo(td_ID,checkboxId){
  td_ID = td_ID.id;
  let containsHire = td_ID.includes("hire");
  let containsDismiss = td_ID.includes("dismiss");
  let containsBuy = td_ID.includes("buy");
  let containsSell = td_ID.includes("sell");
  let containsUnlock = td_ID.includes("unlock");
  let containsTakeoff = td_ID.includes("takeoff");
  let containsLanding = td_ID.includes("landing");
  let containsPilot = td_ID.includes("pilot");
  let containsCabinAttendant = td_ID.includes("cabinattendant");
  let containsPlane = td_ID.includes("plane");
  let containsShowFlight = td_ID.includes("showFlight");

  let attributeCount = 0;
  if(containsHire || containsDismiss || containsBuy || containsSell || containsUnlock)
    attributeCount = 5;
  else if(containsTakeoff || containsLanding)
    attributeCount = 4;
  else if(containsPlane){
    attributeCount = 3;
  }
  else if(containsShowFlight)
    attributeCount = 1;
  else
    attributeCount = 3;
  let selectedRow = document.getElementsByClassName(td_ID);
  let holdNewElement = new Array(attributeCount);

  for(let i = 0; i < attributeCount; i++)
  {
    holdNewElement[i] = selectedRow[i].innerHTML;
  }
  let checkboxHTML ="";
  if(!containsShowFlight)
    checkboxHTML = document.getElementById(checkboxId);

  if(containsHire){
    let index = holdHireArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked)
      holdHireArray.push(holdNewElement);
    else
      holdHireArray.splice(index, 1);
    printHolded("right", "employee");
  }
  else if(containsDismiss){
    let index = holdDismissArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked)
      holdDismissArray.push(holdNewElement);
    else
      holdDismissArray.splice(index, 1);
    printHolded("right", "employee");
  }
  else if(containsBuy){
    let index = holdBuyArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked){
      holdBuyArray.push(holdNewElement);
      financial_turnover = financial_turnover - calculatePlanePrice(holdNewElement[1], holdNewElement[4]);
    }
    else{
      holdBuyArray.splice(index, 1);
      financial_turnover = financial_turnover + calculatePlanePrice(holdNewElement[1], holdNewElement[4]);
    }
    printHolded("right", "airplane");
  }
  else if(containsSell){
    let index = holdSellArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked){
      holdSellArray.push(holdNewElement);
      financial_turnover = financial_turnover + calculatePlanePrice(holdNewElement[1], holdNewElement[4]);
    }
    else{
      holdSellArray.splice(index, 1);
      financial_turnover = financial_turnover - calculatePlanePrice(holdNewElement[1], holdNewElement[4]);
    }
    printHolded("right", "airplane");
  }
  else if(containsUnlock){
    let index = holdUnlockArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked){
      holdUnlockArray.push(holdNewElement[0]);
      financial_turnover = financial_turnover - parseInt(holdNewElement[4]);
    }
    else{
      holdUnlockArray.splice(index, 1);
      financial_turnover = financial_turnover + parseInt(holdNewElement[4]);
    }
    printHolded("right", "airport");
  }
  else if(containsTakeoff){
    let index = holdTakeoffArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    let indexForControl = holdLandingArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked && holdTakeoffArray.length<1 && indexForControl === -1)
      holdTakeoffArray.push(holdNewElement);
    else if(index != -1)
      holdTakeoffArray.splice(index, 1);
    takeOffButton();
    printHolded("right", "takeoff");
    if(indexForControl !== -1)
      alert("This airport is arranged for landing. Please choose a different airport.");
  }
  else if(containsLanding){
    let index = holdLandingArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    let indexForControl = holdTakeoffArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked && holdLandingArray.length<1 && indexForControl === -1)
      holdLandingArray.push(holdNewElement);
    else if(index != -1)
      holdLandingArray.splice(index, 1);
    landingButton();
    printHolded("right", "landing");
    if(indexForControl !== -1)
      alert("This airport is arranged for take-off. Please choose a different airport.");
  }
  else if(containsPilot){
    let index = holdPilotArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked && holdPilotArray.length < 3)
      holdPilotArray.push(holdNewElement);
    else if(index != -1)
      holdPilotArray.splice(index, 1);
    pilotButton();
    printHolded("right", "flight");
  }
  else if(containsCabinAttendant){
    let index = holdCabinAttendantArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked && holdCabinAttendantArray.length < 5)
      holdCabinAttendantArray.push(holdNewElement);
    else if(index != -1)
      holdCabinAttendantArray.splice(index, 1);
    cabinAttendantButton();
    printHolded("right", "flight");
  }
  else if(containsPlane){
    let index = holdPlaneArray.findIndex(arr => JSON.stringify(arr) === JSON.stringify(holdNewElement));
    if(checkboxHTML.checked && holdPlaneArray.length < 1)
      holdPlaneArray.push(holdNewElement);
    else if(index != -1)
      holdPlaneArray.splice(index, 1);
    selectPlaneButton();
    printHolded("right", "flight");
  }
  else if(containsShowFlight){
    showFlightDetailsID = holdNewElement[0];
    showDetails();
  }

}


function clearRightSide()
{
  let rightSideBar = document.querySelector(
    "section .next-day-info"
  );
  let rightSideHTML = '';
  rightSideBar.innerHTML = rightSideHTML;
}


let holdFlightDetails = [2];
let holdHireArray = [];
let holdDismissArray = [];
let holdBuyArray = [];
let holdSellArray = [];
let holdUnlockArray = [];
let holdFlightArray = [];
let holdTakeoffArray = [];
let holdLandingArray = [];
let holdPilotArray = [];
let holdCabinAttendantArray = [];
let holdPlaneArray = [];
let showFlightDetailsID = "";


function printHolded(rightOrLeft, whichOne)
{
  let leftSideBar = document.querySelector(
    "section .left-sidebar"
  );
  let leftSideHTML = '';
  
  let rightSideBar = document.querySelector(
    "section .next-day-info"
  );
  let rightSideHTML = '';
    
  if(holdHireArray.length != 0 && !holdHireArray.includes("?"))
  {
    leftSideHTML += "<div>Hired Employee:<br>";

    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
      rightSideHTML += "<div>Hire Employee Selected:<br>";
    for (let i = 0; i < holdHireArray.length; i++)
    {
      if(rightOrLeft.localeCompare("left") == 0)
        leftSideHTML += ""+ holdHireArray[i] + " <br>";
      else if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
        rightSideHTML += ""+ holdHireArray[i][0] + " <br>";
    }
    leftSideHTML += "</div>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
      rightSideHTML += "</div>";

  }
  if(holdDismissArray.length != 0 && !holdDismissArray.includes("?"))
  {
    leftSideHTML += "<div>Dismissed Employee:<br>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
      rightSideHTML += "<div>Dismiss Employee Selected:<br>";
    for (let i = 0; i < holdDismissArray.length; i++)
    {
      if(rightOrLeft.localeCompare("left") == 0)
        leftSideHTML += ""+ holdDismissArray[i] + " <br>";
      else if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
        rightSideHTML += ""+ holdDismissArray[i][0] + " <br>";
    }
    leftSideHTML += "</div>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("employee") == 0)
      rightSideHTML += "</div>";
  }      
  if(holdUnlockArray.length != 0 && !holdUnlockArray.includes("?"))
  {
    leftSideHTML += "<div>Unlocked Airport:<br>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airport") == 0)
      rightSideHTML += "<div>Airports Selected:<br>";
    for (let i = 0; i < holdUnlockArray.length; i++)
    {
      if(rightOrLeft.localeCompare("left") == 0)
        leftSideHTML += ""+ holdUnlockArray[i] + " <br>";
      else if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airport") == 0)
        rightSideHTML += ""+ holdUnlockArray[i][0] + " <br>";
    }
    leftSideHTML += "</div>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airport") == 0)
      rightSideHTML += "</div>";
    
  }     
  if(holdSellArray.length != 0 && !holdSellArray.includes("?"))
  {
    leftSideHTML += "<div>Airplanes Sold:<br>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
      rightSideHTML += "<div>Airplanes Sell Selected:<br>";
    for (let i = 0; i < holdSellArray.length; i++)
    {
      if(rightOrLeft.localeCompare("left") == 0)
        leftSideHTML += ""+ holdSellArray[i] + " <br>";
      else if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
        rightSideHTML += ""+ holdSellArray[i][0] + " <br>";
    }
    leftSideHTML += "</div>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
      rightSideHTML += "</div>";
   
  }
  if(holdBuyArray.length != 0 && !holdBuyArray.includes("?"))
  {
    leftSideHTML += "<div>Airplanes Bought:<br>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
      rightSideHTML += "<div>Airplanes Buy Selected:<br>";
    for (let i = 0; i < holdBuyArray.length; i++)
    {
      if(rightOrLeft.localeCompare("left") == 0)
        leftSideHTML += ""+ holdBuyArray[i] + " <br>";
      else if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
        rightSideHTML += ""+ holdBuyArray[i][0] + " <br>";
    }
    leftSideHTML += "</div>";
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("airplane") == 0)
      rightSideHTML += "</div>";
  }
  if(holdTakeoffArray.length != 0 || holdLandingArray != 0 || holdPilotArray != 0 || holdCabinAttendantArray != 0|| holdPlaneArray != 0)
  {
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
      rightSideHTML += "<div>Incomplete Flight Details:";

      if(holdTakeoffArray.length != 0)
      {
        if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
          rightSideHTML += "<br>Takeoff: ";
        for (let i = 0; i < holdTakeoffArray.length; i++)
        {
          if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
            rightSideHTML += ""+ holdTakeoffArray[i][0];
        }
      }
      if(holdLandingArray.length != 0)
      {
        if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
          rightSideHTML += "<br>Landing: ";
        for (let i = 0; i < holdLandingArray.length; i++)
        {
          if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
            rightSideHTML += ""+ holdLandingArray[i][0];
        }
      }
      if(holdPilotArray.length != 0)
      {
        if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)  
          rightSideHTML += "<br>Pilot: ";
        for (let i = 0; i < holdPilotArray.length; i++)
        {
          if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
            rightSideHTML += ""+ holdPilotArray[i][0] + "  ";
        }
      }
      if(holdCabinAttendantArray.length != 0)
      {
        if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
          rightSideHTML += "<br>Cabin Attendant: ";
        for (let i = 0; i < holdCabinAttendantArray.length; i++)
        {
          if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
            rightSideHTML += ""+ holdCabinAttendantArray[i][0] + "  ";
        }
      }
      if(holdPlaneArray.length != 0)
      {
        if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
          rightSideHTML += "<br>Plane: ";
        for (let i = 0; i < holdPlaneArray.length; i++)
        {
          if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
            rightSideHTML += ""+ holdPlaneArray[i][0];
        }
      }
    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
      rightSideHTML += "</div>";
  }

  if(holdFlightArray.length !== 0 && !holdFlightArray.includes("?"))
  {
    if(rightOrLeft.localeCompare("left") == 0)
    {
      leftSideHTML += "<div>";
      for(let i = 0; i<holdFlightArray.length - 1; i++)
      {
        if(i == 0){
          leftSideHTML += (i + 1) + ". Flight:";
        }
        else{
          leftSideHTML += "<br>" + (i + 1) + ". Flight:";
        }
        for(let j = 0; j<holdFlightArray[i].length - 1; j++)
        {
          if(j == 0){
            leftSideHTML += "<br>Takeoff: ";
            leftSideHTML += holdFlightArray[i].split(";")[0];
          }
          if(j == 1){
            leftSideHTML += "<br>Landing: ";
            leftSideHTML += holdFlightArray[i].split(";")[1];
          }
          if(j == 2){
            leftSideHTML += "<br>Pilots: ";
            leftSideHTML += holdFlightArray[i].split(";")[2];
          }
          if(j == 3){
            leftSideHTML += "<br>Cabin Attendants: ";
            leftSideHTML += holdFlightArray[i].split(";")[3];
          }
          
          if(j == 4){
            leftSideHTML += "<br>Plane: ";
            leftSideHTML += holdFlightArray[i].split(";")[4];
          }
          
        }
      }
      leftSideHTML += "</div>";
    }

    if(rightOrLeft.localeCompare("right") == 0 && whichOne.localeCompare("flight") == 0)
    {
      rightSideHTML += "<div>";
      for(let i = 0; i<holdFlightArray.length; i++)
      {
        if(i == 0){
          rightSideHTML += (i + 1) + ". Flight:";
        }
        else{
          rightSideHTML += "<br>" + (i + 1) + ". Flight:";
        }
        for(let j = 0; j<holdFlightArray[0].length - 1; j++)
        {
          if(j == 0)
            rightSideHTML += "<br>Takeoff: ";
          if(j == 1)
            rightSideHTML += "<br>Landing: ";
          if(j == 2)
            rightSideHTML += "<br>Pilots: ";
          if(j == 3)
            rightSideHTML += "<br>Cabin Attendants: ";
          if(j == 4)
            rightSideHTML += "<br>Plane: ";
          rightSideHTML += holdFlightArray[i][j];
        }
      }
      rightSideHTML += "</div>";
    }
  }
  
  if(rightOrLeft.localeCompare("left") == 0)
    leftSideBar.innerHTML = leftSideHTML;
  else
    rightSideBar.innerHTML = rightSideHTML;
}

async function createFlight(){
  let checkCounter = 0;
  if(holdTakeoffArray.length == 1)
    checkCounter++;
  if(holdLandingArray.length == 1)
    checkCounter++;
  if(2 <= holdPilotArray.length <= 3)
    checkCounter++;
  if(3 <= holdCabinAttendantArray.length <= 5)
    checkCounter++;
  if(holdPlaneArray.length == 1)
    checkCounter++;
  if(checkCounter == 5)
  {
    let holdFlight = [];
    let pilotString = "";
    let cabinAttendantString = "";
    for(let i = 0; i<holdPilotArray.length; i++)
    {
      if(i == holdPilotArray.length-1)
        pilotString += holdPilotArray[i][0];
      else
        pilotString += holdPilotArray[i][0] + ",";
    }

    for(let i = 0; i<holdCabinAttendantArray.length; i++)
    {
      if(i == holdCabinAttendantArray.length-1)
        cabinAttendantString += holdCabinAttendantArray[i][0];
      else
        cabinAttendantString += holdCabinAttendantArray[i][0] + ",";
    }

    holdFlight.push(holdTakeoffArray[0][0]);
    holdFlight.push(holdLandingArray[0][0]);
    holdFlight.push(pilotString);
    holdFlight.push(cabinAttendantString);
    holdFlight.push(holdPlaneArray[0][0]);
    holdFlight.push(holdPlaneArray[0][1]);
    holdFlightArray.push(holdFlight);
    
    try {
      const response = await fetch('http://localhost:5001/api/setFlightStatus?pilot_id=' + pilotString + '&cabin_id=' + cabinAttendantString + '&plane_id=' + holdPlaneArray[0][0]);
    } catch {
      return alert('ERROR')
    }

    createFlight_clicked = 1;
    getCabinAttendantArray();
    getPilotArray();
    flightAirplaneGetArray();
    holdTakeoffArray = [];
    holdLandingArray = [];
    holdPilotArray = [];
    holdCabinAttendantArray = [];
    holdPlaneArray = [];
    generateFlight();
    printHolded("right", "flight");
  }
}


// Next Day Button
async function nextDay(){
  if(money >= (-1 * financial_turnover)){
    if(holdHireArray[0] !== undefined){
      try {
        let id_string = "";
        for(let i = 0; i < holdHireArray.length; i++){
          if(i === holdHireArray.length - 1){
            id_string += holdHireArray[i][0];
          }
          else{
            id_string += holdHireArray[i][0] + ",";
          }
        }
        const response = await fetch('http://localhost:5001/api/nextHire?id=' + id_string + "&username=" + username);
      } catch {
        return alert('ERROR')
      }
    }
  
    if(holdDismissArray[0] !== undefined){
      try {
        let id_string = "";
        for(let i = 0; i < holdDismissArray.length; i++){
          if(i === holdDismissArray.length - 1){
            id_string += holdDismissArray[i][0];
          }
          else{
            id_string += holdDismissArray[i][0] + ",";
          }
        }
        const response = await fetch('http://localhost:5001/api/nextDismiss?id=' + id_string);
        const wrongIds = await response.json();
        let anotherArray = [...wrongIds];
        if (anotherArray.length !== 0) {
          alert("You can't dismiss the employees scheduled for the flight!");
          for (let m = 0; m < anotherArray.length; m++) {
            let index = holdDismissArray.findIndex(element => element[0] === anotherArray[m]);
            if (index !== -1) {
                holdDismissArray.splice(index, 1);
            }
        }
      }
      } catch {
        return alert('ERROR')
      }
    }
  
    if(holdBuyArray[0] !== undefined){
      try {
        let id_string = "";
        for(let i = 0; i < holdBuyArray.length; i++){
          if(i === holdBuyArray.length - 1){
            id_string += holdBuyArray[i][0];
          }
          else{
            id_string += holdBuyArray[i][0] + ",";
          }
        }
        const response = await fetch('http://localhost:5001/api/nextBuyPlane?id=' + id_string + "&username=" + username);
      } catch {
        return alert('ERROR')
      }
    }
  
    if(holdSellArray[0] !== undefined){
      try {
        let id_string = "";
        for(let i = 0; i < holdSellArray.length; i++){
          if(i === holdSellArray.length - 1){
            id_string += holdSellArray[i][0];
          }
          else{
            id_string += holdSellArray[i][0] + ",";
          }
        }
        const response = await fetch('http://localhost:5001/api/nextSellPlane?id=' + id_string);
        const wrongIds = await response.json();
        let anotherArray = [...wrongIds];
        if (anotherArray.length !== 0) {
          alert("You can't sell the plane scheduled for the flight!");
          for (let m = 0; m < anotherArray.length; m++) {
            let index = holdSellArray.findIndex(element => element[0] === anotherArray[m]);
            if (index !== -1) {
                holdSellArray.splice(index, 1);
            }
          }
        }
      } catch {
        return alert('ERROR')
      }
    }
  
    if(holdUnlockArray[0] !== undefined){
      try {
        let id_string = "";
        for(let i = 0; i < holdUnlockArray.length; i++){
          if(i === holdUnlockArray.length - 1){
            id_string += holdUnlockArray[i][0];
          }
          else{
            id_string += holdUnlockArray[i][0] + ",";
          }
        }
        const response = await fetch('http://localhost:5001/api/nextUnlockAirport?id=' + id_string + "&username=" + username);
      } catch {
        return alert('ERROR')
      }
    }
  
    if(holdFlightArray[0] !== undefined){
      let flights = []; 
      let ticket_count = 0;
      let total_income = 0;
      for(let i = 0; i < holdFlightArray.length; i++){
        let ticket_score = getTicketScore(holdFlightArray[i]);
        if(holdFlightArray[i][5] === "DEU-AIRLINES-A200"){
          let a_class = parseInt(10 * ticket_score);
          let b_class = parseInt(190 * ticket_score);
          flights.push("160,130," + a_class + "," + b_class + "")
          ticket_count += a_class + b_class;
          total_income += ((a_class * 160) + (b_class * 130))
        }
        if(holdFlightArray[i][5] === "DEU-AIRLINES-A300"){
          let a_class = parseInt(20 * ticket_score);
          let b_class = parseInt(280 * ticket_score);
          flights.push("200,160," + a_class + "," + b_class + "")
          ticket_count += a_class + b_class;
          total_income += ((a_class * 200) + (b_class * 160))
        }
        if(holdFlightArray[i][5] === "DEU-AIRLINES-A400"){
          let a_class = parseInt(30 * ticket_score);
          let b_class = parseInt(370 * ticket_score);
          flights.push("240,190," + a_class + "," + b_class + "")
          ticket_count += a_class + b_class;
          total_income += ((a_class * 240) + (b_class * 190))
        }
      }
      
      for(let i = 0; i < holdFlightArray.length; i++){
        let take_off = holdFlightArray[i][0];
        let landing = holdFlightArray[i][1];
        let pilot_id = holdFlightArray[i][2];
        let cabin_attendant_id = holdFlightArray[i][3];
        let plane = holdFlightArray[i][4];
        let flightDay = day + 1;

        try {
          const response = await fetch('http://localhost:5001/api/nextFlight?take_off=' + take_off + "&landing=" + landing + "&pilot_id=" + pilot_id + "&cabin_attendant_id=" + cabin_attendant_id + "&plane=" + plane + "&day=" + flightDay + "&username=" + username);
        } catch {
          return alert('ERROR')
        }

        try {
          const response = await fetch('http://localhost:5001/api/createTicket?&ticketNumber=' + flights[i].split(",")[2] + "&price=" + flights[i].split(",")[0]);
        } catch {
          return alert('ERROR')
        }
        try {
          const response = await fetch('http://localhost:5001/api/createTicket?&ticketNumber=' + flights[i].split(",")[3] + "&price=" + flights[i].split(",")[1]);
        } catch {
          return alert('ERROR')
        }
        money += total_income;
      }
    }
    try {
      let flightDay = day + 1;
      let userMoney = money + financial_turnover;
      const response = await fetch('http://localhost:5001/api/nextSetFree?money=' + userMoney + "&username=" + username + "&money=" + userMoney + "&day=" + flightDay);
    } catch {
      return alert('ERROR')
    }

    holdArrayToString();
    nextDayAnimation();
  }else{
    alert("Your money is not enough!")
  }
}


//Animation
function nextDayAnimation(){
  let sectionAnimation = document.querySelector("section");
  let sectionHTML = '<div id = "movingImage" class="image-container"><img class="moving-image" src="/images/animation.png" alt="Moving Image"><div>';
  sectionAnimation.innerHTML = sectionHTML;
  const movingImage = document.getElementById('movingImage');
  movingImage.addEventListener('animationend', afterAnimation);
}
function afterAnimation(){
  window.location.href = "/game";
}


//Calculating money
function calculatePlanePrice(plane_model_name, flight_count){
  let price =0;
  if(plane_model_name === "DEU-AIRLINES-A200"){
    price = 1000000 - (flight_count * 400) ;
  }
  else if(plane_model_name === "DEU-AIRLINES-A300"){
    price = 2000000 - (flight_count * 390) ;
  }
  else{
    price = 3000000 - (flight_count * 380) ;
  }
  return price;
}
function calculateEmployeeSalary(profession, flight_count){
  let salary = 0;
  if(profession == 'pilot'){
    if(flight_count < 300){
      salary = 1000;
    }else if (flight_count < 700){
      salary = 1250;
    }else {
      salary = 1500;
    }
  }else{
    if(flight_count < 300){
      salary = 500
    }else if (flight_count < 700){
      salary = 600
    }else {
      salary = 700
    }
  }
  return salary;
}
function getMaxMinFlight(level){
  let maxFlightCountReturn = -1;
  let minFlightCountReturn = -1;
  if(level === "entry"){
    maxFlightCountReturn = 300;
  }
  if(level === "mid"){
    minFlightCountReturn = 300;
    maxFlightCountReturn = 700;
  }
  if(level === "senior"){
    minFlightCountReturn = 700;
  }
  return minFlightCountReturn + "," + maxFlightCountReturn;
}
function expCalculator(flightCount)
{
  if(flightCount > 700)
    return "Senior Level";
  else if(flightCount > 300)
    return "Mid Level";
  else
    return "Entry Level";
}
async function calculateEmployeeSalaryForAll(){
  let totalSalary = 0;
  try {
    const response = await fetch('http://localhost:5001/api/getFCAndProfession?username=' + username);
    const player = await response.json();
    let temp = [];
    player.forEach(row => {
      const rowArray = Object.values(row);
      temp.push(rowArray);
    });
    
    for(let i = 0;i < temp.length; i++){
      totalSalary += calculateEmployeeSalary(temp[i][0], temp[i][1])
    }
  } catch {
    return alert('ERROR')
  }
  employee_outgoing_for_one_day = totalSalary;
  financial_turnover -= totalSalary;
}
async function calculateBankCredit(){
  let credit = 0;
  try {
    const response = await fetch('http://localhost:5001/api/bankCredit?&username=' + username);
    const player = await response.json();
    let temp = [];
    player.forEach(row => {
      const rowArray = Object.values(row);      
      temp.push(rowArray);
    });
    for(let i = 0;i < temp.length; i++){
      credit += ((temp[i][0] + (temp[i][0] * temp[i][2] / 100))) / temp[i][3];
    }
  } catch {
    return alert('ERROR')
  }
  bank_outgoing_for_one_day = credit;
  financial_turnover -= credit;
  document.getElementById('bank-outgoing-footer').innerText = 'Bank Outgoing: ' + bank_outgoing_for_one_day;
  document.getElementById('employee-outgoing-footer').innerText = 'Crews Outgoing: ' + employee_outgoing_for_one_day;
}
function getTicketScore(flightArray){
  let ticketScore = 0.7;
  if(flightArray[2].split(",").length === 3){
    ticketScore += 0.15;
  }
  if(flightArray[3].split(",").length === 4){
    ticketScore += 0.07;
  }
  if(flightArray[3].split(",").length === 5){
    ticketScore += 0.15;
  }
  return ticketScore;
}


//Converting hold arrays to string for day logs
async function holdArrayToString()
{
  let dayLogString = "";
  if(holdHireArray.length != 0){
    for(let i = 0; i < holdHireArray.length; i++){
    if(i === holdHireArray.length - 1){
      dayLogString += holdHireArray[i][0] + ";";
    }
    else{
      dayLogString += holdHireArray[i][0] + ",";
    }
    }
  }
  else{
    dayLogString += "?;";
  }
  if(holdDismissArray.length != 0){
    for(let i = 0; i < holdDismissArray.length; i++){
    if(i === holdDismissArray.length - 1){
      dayLogString += holdDismissArray[i][0] + ";";
    }
    else{
      dayLogString += holdDismissArray[i][0] + ",";
    }
    }
  }
  else{
    dayLogString += "?;";
  }
  if(holdBuyArray.length != 0){
    for(let i = 0; i < holdBuyArray.length; i++){
    if(i === holdBuyArray.length - 1){
      dayLogString += holdBuyArray[i][0] + ";";
    }
    else{
      dayLogString += holdBuyArray[i][0] + ",";
    }
    }
  }
  else{
    dayLogString += "?;";
  }
  if(holdSellArray.length != 0){
    for(let i = 0; i < holdSellArray.length; i++){
    if(i === holdSellArray.length - 1){
      dayLogString += holdSellArray[i][0] + ";";
    }
    else{
      dayLogString += holdSellArray[i][0] + ",";
    }
    }
  }
  else{
    dayLogString += "?;";
  }
  if(holdUnlockArray.length != 0){
    for(let i = 0; i < holdUnlockArray.length; i++){
    if(i === holdUnlockArray.length - 1){
      dayLogString += holdUnlockArray[i] + ";";
    }
    else{
      dayLogString += holdUnlockArray[i] + ",";
    }
    }
  }
  else{
    dayLogString += "?;";
  }

  if(holdFlightArray.length != 0){
    for(let i = 0; i < holdFlightArray.length; i++){
      for(let j = 0; j < holdFlightArray[i].length - 1; j++){
        if(j === 2){
          tempPilot = holdFlightArray[i][j].split(",");
          tempPilotString = "";
          for(let k = 0; k < tempPilot.length; k++)
          {
            if(k !== tempPilot.length - 1){
              tempPilotString += tempPilot[k] + "-";
            }
            else{
              tempPilotString += tempPilot[k] + ",";
            }
          }
          dayLogString += tempPilotString;
        }
        else if(j === 3)
        {
          tempCabinAttendant = holdFlightArray[i][j].split(",");
          tempCabinAttendantString = "";
          for(let k = 0; k < tempCabinAttendant.length; k++)
          {
            if(k !== tempCabinAttendant.length - 1){
              tempCabinAttendantString += tempCabinAttendant[k] + "-";
            }
            else{
              tempCabinAttendantString += tempCabinAttendant[k] + ",";
            }
          }
          dayLogString += tempCabinAttendantString;
        }
        else if(j === holdFlightArray[i].length - 1){
          if(i === holdFlightArray.length - 1)
            dayLogString += holdFlightArray[i][j];
          else
            dayLogString += holdFlightArray[i][j] + "/";
        }
        else{
          dayLogString += holdFlightArray[i][j] + ",";
        }
      }
      dayLogString += "/";
    }
  }
  else{
    dayLogString += "?";
  }
  try {
    const response = await fetch('http://localhost:5001/api/insertDayLog?dayLog=' + dayLogString + "&username=" + username + "&day=" + day);
  } catch {
    return alert('ERROR')
  }
}