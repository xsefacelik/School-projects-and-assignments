const express = require("express");
const mysql = require("mysql");
const dotenv = require("dotenv");
const path = require("path");

dotenv.config({ path: "./.env" });

const db = mysql.createConnection({
  host: process.env.DATABASE_HOST,
  user: process.env.DATABASE_USER,
  password: process.env.DATABASE_PASSWORD,
  database: process.env.DATABASE,
});

const app = express();

const publicDirectory = path.join(__dirname, "./public");
app.use(express.static(publicDirectory));


app.set("view engine", "hbs");
app.get("/", (req, res) => {
  res.render("index");
});
app.get("/index", (req, res) => {
  res.render("index");
});
app.get("/login", (req, res) => {
  res.render("login");
});
app.get("/game", (req, res) => {
  res.render("game");
});
app.get("/difficulty", (req, res) => {
  res.render("difficulty");
});


app.get("/api/playerJoinCheck", (req, res) => {
  let username = req.query.username;
  let query = "SELECT username FROM player WHERE username = '" + username + "'";

  db.query(query, function (error, result, fields) {
    if (error) throw error;

    if (result.length === 0) {
      res.json({ exists: false });
    } else {
      res.json({ exists: true });
    }
  });
});
app.get("/api/playerLoginCheck", (req, res) => {
  let username = req.query.username;
  let password = req.query.password;
  let query = "SELECT username FROM player WHERE username = '" + username + "' AND password = '" + password + "' AND activity = 'offline'";

  db.query(query, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/playerOnline", (req, res) => {
  let username = req.query.username;
  let query = "UPDATE player SET activity = 'online' WHERE username = '" + username + "'";

  db.query(query, function (error, result, fields) {
    if (error) throw error;
    res.json({ exists: true });
  });
});
app.get("/api/playerOffline", (req, res) => {
  let username = req.query.username;
  let query = "UPDATE player SET activity = 'offline' WHERE username = '" + username + "'";

  db.query(query, function (error, result, fields) {
    if (error) throw error;
    res.json({ exists: true });
  });
});


app.get("/api/getPlayerInfo", (req, res) => {
  let query = "SELECT username, money, day FROM player WHERE activity = 'online'";
  let queryBank = "SELECT taken_loan.credit_amount FROM taken_loan JOIN player ON taken_loan.username = player.username WHERE player.activity = 'online' AND taken_loan.remaining_day >= 0";
  let dataArray = []; 
  db.query(query, function (error, result, fields) {
    if (error) throw error;
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    db.query(queryBank, function (error, result1, fields) {
      if (error) throw error;
      result1.forEach(row => {
        const rowArray1 = Object.values(row);
        dataArray[0].push(rowArray1[0]);
      });
      return res.send(dataArray);
    });
  });
});
app.get("/api/getCompanyInfo", (req, res) => {
  let username = req.query.username;
  let queryPlane = "SELECT COUNT(*) FROM plane WHERE username = '" + username + "'";
  let queryAirport = "SELECT COUNT(*) FROM unlocked_airport WHERE username = '" + username + "'";
  let queryEmployee = "SELECT COUNT(*) FROM employee WHERE username = '" + username + "'";
  let flightCountQuery = "SELECT COUNT(*) FROM flight WHERE username = '" + username + "'";
  let ticketCountQuery = "SELECT COUNT(*) FROM ticket JOIN flight ON ticket.flight_id = flight.flight_id WHERE username = '" + username + "'";

  let dataArray = []; 
  db.query(queryPlane, function (error, result1, fields) {
    if (error) throw error;
    result1.forEach(row => {
      const rowArray1 = Object.values(row);
      dataArray.push(rowArray1);
    });
  });
  db.query(queryAirport, function (error, result2, fields) {
    if (error) throw error;
    result2.forEach(row => {
      const rowArray2 = Object.values(row);
      dataArray.push(rowArray2);
    });
  });
  db.query(queryEmployee, function (error, result3, fields) {
    if (error) throw error;
    result3.forEach(row => {
      const rowArray3 = Object.values(row);
      dataArray.push(rowArray3);
    });
  });
  db.query(flightCountQuery, function (error, result4, fields) {
    if (error) throw error;
    result4.forEach(row => {
      const rowArray4 = Object.values(row);
      dataArray.push(rowArray4);
    });
  });
  db.query(ticketCountQuery, function (error, result5, fields) {
    if (error) throw error;
    result5.forEach(row => {
      const rowArray5 = Object.values(row);
      dataArray.push(rowArray5);
    });
    return res.send(dataArray);
  });
});


app.get("/api/playerInsert", (req, res) => {
  let username = req.query.username;
  let password = req.query.password;
  let company_name = username + " Airlines";
  let query = "INSERT INTO player (username, password, company_name, money) VALUES ('" + username + "', '" + password + "', '" + company_name + "', '3200000')"; 

  db.query(query, function (error, result, fields) {
    if (error) throw error;
    res.json({ exists: true});
  });
});


app.get("/api/employee/hire", (req, res) => {
  let first_last = req.query.first_last;
  let hireFilterNameValue = req.query.hireFilterNameValue;
  let hireFilterMinFlightCount = req.query.hireFilterMinFlightCount;
  let hireFilterMaxFlightCount = req.query.hireFilterMaxFlightCount;
  let hireFilterProfessionValue = req.query.hireFilterProfessionValue; 

  let nameQuery = "";
  let minFlightCountQuery = "";
  let maxFlightCountQuery = "";
  let professionQuery = "";

  let queryArr = [];
  if(hireFilterNameValue !== "?"){
    nameQuery = " name = '" + hireFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(hireFilterMinFlightCount !== "-1"){
    minFlightCountQuery = " flight_count > " + hireFilterMinFlightCount + "";
    queryArr.push(minFlightCountQuery);
  }
  if(hireFilterMaxFlightCount !== "-1"){
    maxFlightCountQuery = " flight_count < " + hireFilterMaxFlightCount + "";
    queryArr.push(maxFlightCountQuery);
  }
  if(hireFilterProfessionValue !== "?"){
    professionQuery = " profession = '" + hireFilterProfessionValue + "'";
    queryArr.push(professionQuery);
  }

  let  queryString = "SELECT employee.employee_id,person.name,employee.flight_count,employee.profession,person.lastname FROM employee JOIN person ON employee.ssn = person.ssn WHERE employee.username = 'admin'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/employee/dismiss", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let dismissFilterNameValue = req.query.dismissFilterNameValue;
  let dismissFilterMinFlightCount = req.query.dismissFilterMinFlightCount;
  let dismissFilterMaxFlightCount = req.query.dismissFilterMaxFlightCount;
  let dismissFilterProfessionValue = req.query.dismissFilterProfessionValue; 

  let nameQuery = "";
  let minFlightCountQuery = "";
  let maxFlightCountQuery = "";
  let professionQuery = "";

  let queryArr = [];
  if(dismissFilterNameValue !== "?"){
    nameQuery = " name = '" + dismissFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(dismissFilterMinFlightCount !== "-1"){
    minFlightCountQuery = " flight_count > " + parseInt(dismissFilterMinFlightCount) + "";
    queryArr.push(minFlightCountQuery);
  }
  if(dismissFilterMaxFlightCount !== "-1"){
    maxFlightCountQuery = " flight_count < " + parseInt(dismissFilterMaxFlightCount) + "";
    queryArr.push(maxFlightCountQuery);
  }
  if(dismissFilterProfessionValue !== "?"){
    professionQuery = " profession = '" + dismissFilterProfessionValue + "'";
    queryArr.push(professionQuery);
  }

  let queryString = "SELECT employee.employee_id,person.name,employee.flight_count,employee.profession,person.lastname FROM employee JOIN person ON employee.ssn = person.ssn WHERE username = '" + username + "'";

  for(let i = 0; i < queryArr.length; i++){
    for(let i = 0; i < queryArr.length; i++){
      queryString += " AND" + queryArr[i];
    }
  }
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/employee/show", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let showFilterNameValue = req.query.showFilterNameValue;
  let showFilterMinFlightCount = req.query.showFilterMinFlightCount;
  let showFilterMaxFlightCount = req.query.showFilterMaxFlightCount;
  let showFilterProfessionValue = req.query.showFilterProfessionValue; 

  let nameQuery = "";
  let minFlightCountQuery = "";
  let maxFlightCountQuery = "";
  let professionQuery = "";

  let queryArr = [];
  if(showFilterNameValue !== "?"){
    nameQuery = " name = '" + showFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(showFilterMinFlightCount !== "-1"){
    minFlightCountQuery = " flight_count > " + parseInt(showFilterMinFlightCount) + "";
    queryArr.push(minFlightCountQuery);
  }
  if(showFilterMaxFlightCount !== "-1"){
    maxFlightCountQuery = " flight_count < " + parseInt(showFilterMaxFlightCount) + "";
    queryArr.push(maxFlightCountQuery);
  }
  if(showFilterProfessionValue !== "?"){
    professionQuery = " profession = '" + showFilterProfessionValue + "'";
    queryArr.push(professionQuery);
  }

  let queryString = "";
  
  queryString = "SELECT employee.employee_id,person.name,employee.flight_count,employee.profession,person.lastname FROM employee JOIN person ON employee.ssn = person.ssn WHERE username = '" + username + "'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/employee/buyAirplane", (req, res) => {
  let first_last = req.query.first_last;
  let buyAirplaneType1Checked = req.query.buyAirplaneType1Checked;
  let buyAirplaneType2Checked = req.query.buyAirplaneType2Checked;
  let buyAirplaneType3Checked = req.query.buyAirplaneType3Checked;

  let type_one_Query = "";
  let type_two_Query = "";
  let type_three_Query = "";

  let queryArr = [];
  let typeArr = [];

  if(buyAirplaneType1Checked === "false" && buyAirplaneType2Checked === "false" && buyAirplaneType3Checked === "false"){
    buyAirplaneType1Checked = "true";
    buyAirplaneType2Checked = "true";
    buyAirplaneType3Checked = "true";
  }
  if(buyAirplaneType1Checked === "true"){
    type_one_Query = " plane.model_name = 'DEU-AIRLINES-A200'";
    typeArr.push(type_one_Query);
  }
  if(buyAirplaneType2Checked === "true"){
    type_two_Query = " plane.model_name = 'DEU-AIRLINES-A300'";
    typeArr.push(type_two_Query);
  }
  if(buyAirplaneType3Checked === "true"){
    type_three_Query = " plane.model_name = 'DEU-AIRLINES-A400'";
    typeArr.push(type_three_Query);
  }

  let  queryString = "SELECT plane.plane_id,plane.model_name,plane_type.a_class_capacity,plane_type.b_class_capacity, plane.flight_count FROM plane JOIN plane_type ON plane.model_name = plane_type.model_name WHERE plane.username = 'admin' AND";

  let typeString = "(";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      typeString += typeArr[i];
    }
    else{
      typeString += typeArr[i] + " OR";
    }
  }

  typeString += ")";
  queryString += typeString;

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/employee/sellAirplane", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let sellAirplaneType1Checked = req.query.sellAirplaneType1Checked;
  let sellAirplaneType2Checked = req.query.sellAirplaneType2Checked;
  let sellAirplaneType3Checked = req.query.sellAirplaneType3Checked;
  
  let type_one_Query = "";
  let type_two_Query = "";
  let type_three_Query = "";

  let queryArr = [];
  let typeArr = [];

  if(sellAirplaneType1Checked === "false" && sellAirplaneType2Checked === "false" && sellAirplaneType3Checked === "false"){
    sellAirplaneType1Checked = "true";
    sellAirplaneType2Checked = "true";
    sellAirplaneType3Checked = "true";
  }
  if(sellAirplaneType1Checked === "true"){
    type_one_Query = " plane.model_name = 'DEU-AIRLINES-A200'";
    typeArr.push(type_one_Query);
  }
  if(sellAirplaneType2Checked === "true"){
    type_two_Query = " plane.model_name = 'DEU-AIRLINES-A300'";
    typeArr.push(type_two_Query);
  }
  if(sellAirplaneType3Checked === "true"){
    type_three_Query = " plane.model_name = 'DEU-AIRLINES-A400'";
    typeArr.push(type_three_Query);
  }

  let  queryString = "SELECT plane.plane_id,plane.model_name,plane_type.a_class_capacity,plane_type.b_class_capacity,plane.flight_count FROM plane JOIN plane_type ON plane.model_name = plane_type.model_name WHERE plane.username = '" + username + "' AND";

  let typeString = " (";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      typeString += typeArr[i];
    }
    else{
      typeString += typeArr[i] + " OR";
    }
  }
  typeString += ")";
  queryString += typeString;

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/employee/showAirplane", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let showAirplaneType1Checked = req.query.showAirplaneType1Checked;
  let showAirplaneType2Checked = req.query.showAirplaneType2Checked;
  let showAirplaneType3Checked = req.query.showAirplaneType3Checked;
  
  let type_one_Query = "";
  let type_two_Query = "";
  let type_three_Query = "";

  let queryArr = [];
  let typeArr = [];

  if(showAirplaneType1Checked === "false" && showAirplaneType2Checked === "false" && showAirplaneType3Checked === "false"){
    showAirplaneType1Checked = "true";
    showAirplaneType2Checked = "true";
    showAirplaneType3Checked = "true";
  }
  if(showAirplaneType1Checked === "true"){
    type_one_Query = " plane.model_name = 'DEU-AIRLINES-A200'";
    typeArr.push(type_one_Query);
  }
  if(showAirplaneType2Checked === "true"){
    type_two_Query = " plane.model_name = 'DEU-AIRLINES-A300'";
    typeArr.push(type_two_Query);
  }
  if(showAirplaneType3Checked === "true"){
    type_three_Query = " plane.model_name = 'DEU-AIRLINES-A400'";
    typeArr.push(type_three_Query);
  }

  let  queryString = "SELECT plane.plane_id,plane.model_name,plane_type.a_class_capacity,plane_type.b_class_capacity,plane.flight_count FROM plane JOIN plane_type ON plane.model_name = plane_type.model_name WHERE plane.username = '" + username + "' AND";

  let typeString = " (";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      typeString += typeArr[i];
    }
    else{
      typeString += typeArr[i] + " OR";
    }
  }

  typeString += ")";
  queryString += typeString;

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/unlockAirport", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let unlockFilterNameValue = req.query.unlockFilterNameValue;
  let unlockFilterCityValue = req.query.unlockFilterCityValue;
  let unlockFilterCountryValue = req.query.unlockFilterCountryValue;
  
  let queryArr = [];
  
  if(unlockFilterNameValue !== "?"){
    nameQuery = "name = '" + unlockFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(unlockFilterCityValue !== "?"){
    cityQuery = "city = '" + unlockFilterCityValue + "'";
    queryArr.push(cityQuery);
  }
  if(unlockFilterCountryValue !== "?"){
    countryQuery = "country = '" + unlockFilterCountryValue + "'";
    queryArr.push(countryQuery);
  }

  let  queryString = "SELECT * FROM airport WHERE "; 

  for(let i = 0; i < queryArr.length; i++){
      queryString +=  queryArr[i] + " AND " ;
  }
  
  queryString+= "airport.airport_id NOT IN (SELECT unlocked_airport.airport_id FROM unlocked_airport WHERE username = '" + username + "')";

  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/showAirport", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let showAirportFilterNameValue = req.query.showAirportFilterNameValue;
  let showAirportFilterCityValue = req.query.showAirportFilterCityValue;
  let showAirportFilterCountryValue = req.query.showAirportFilterCountryValue;
  
  let queryArr = [];
  
  if(showAirportFilterNameValue !== "?"){
    nameQuery = "name = '" + showAirportFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(showAirportFilterCityValue !== "?"){
    cityQuery = "city = '" + showAirportFilterCityValue + "'";
    queryArr.push(cityQuery);
  }
  if(showAirportFilterCountryValue !== "?"){
    countryQuery = "country = '" + showAirportFilterCountryValue + "'";
    queryArr.push(countryQuery);
  }

  let  queryString = "SELECT * FROM airport WHERE "; 

  for(let i = 0; i < queryArr.length; i++){
      queryString +=  queryArr[i] + " AND " ;
  }
  
  queryString+= "airport.airport_id IN (SELECT unlocked_airport.airport_id FROM unlocked_airport WHERE username = '" + username + "')";

  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/takeOff", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let takeOffFilterNameValue = req.query.takeOffFilterNameValue;
  let takeOffFilterCityValue = req.query.takeOffFilterCityValue;
  let takeOffFilterCountryValue = req.query.takeOffFilterCountryValue;
  
  let queryArr = [];
  
  if(takeOffFilterNameValue !== "?"){
    nameQuery = "name = '" + takeOffFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(takeOffFilterCityValue !== "?"){
    cityQuery = "city = '" + takeOffFilterCityValue + "'";
    queryArr.push(cityQuery);
  }
  if(takeOffFilterCountryValue !== "?"){
    countryQuery = "country = '" + takeOffFilterCountryValue + "'";
    queryArr.push(countryQuery);
  }

  let  queryString = "SELECT * FROM airport WHERE "; 

  for(let i = 0; i < queryArr.length; i++){
      queryString +=  queryArr[i] + " AND " ;
  }
  
  queryString+= "airport.airport_id IN (SELECT unlocked_airport.airport_id FROM unlocked_airport WHERE username = '" + username + "')";

  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/landing", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let landingFilterNameValue = req.query.landingFilterNameValue;
  let landingFilterCityValue = req.query.landingFilterCityValue;
  let landingFilterCountryValue = req.query.landingFilterCountryValue;
  
  let queryArr = [];
  
  if(landingFilterNameValue !== "?"){
    nameQuery = "name = '" + landingFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(landingFilterCityValue !== "?"){
    cityQuery = "city = '" + landingFilterCityValue + "'";
    queryArr.push(cityQuery);
  }
  if(landingFilterCountryValue !== "?"){
    countryQuery = "country = '" + landingFilterCountryValue + "'";
    queryArr.push(countryQuery);
  }

  let  queryString = "SELECT * FROM airport WHERE "; 

  for(let i = 0; i < queryArr.length; i++){
      queryString +=  queryArr[i] + " AND " ;
  }
  queryString+= "airport.airport_id IN (SELECT unlocked_airport.airport_id FROM unlocked_airport WHERE username = '" + username + "')";

  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/pilot", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let pilotFilterNameValue = req.query.pilotFilterNameValue;
  let pilotFilterMinFlightCount = req.query.pilotFilterMinFlightCount;
  let pilotFilterMaxFlightCount = req.query.pilotFilterMaxFlightCount;

  let nameQuery = "";
  let minFlightCountQuery = "";
  let maxFlightCountQuery = "";

  let queryArr = [];
  if(pilotFilterNameValue !== "?"){
    nameQuery = " name = '" + pilotFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(pilotFilterMinFlightCount !== "-1"){
    minFlightCountQuery = " flight_count > " + parseInt(pilotFilterMinFlightCount) + "";
    queryArr.push(minFlightCountQuery);
  }
  if(pilotFilterMaxFlightCount !== "-1"){
    maxFlightCountQuery = " flight_count < " + parseInt(pilotFilterMaxFlightCount) + "";
    queryArr.push(maxFlightCountQuery);
  }

  let queryString = "";
  
  queryString = "SELECT employee.employee_id,person.name,employee.flight_count,person.lastname FROM employee JOIN person ON employee.ssn = person.ssn WHERE username = '" + username + "' AND employee.profession = 'pilot' AND employee.status = 'free'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/cabinAttendant", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let cabinAttendantFilterNameValue = req.query.cabinAttendantFilterNameValue;
  let cabinAttendantFilterMinFlightCount = req.query.cabinAttendantFilterMinFlightCount;
  let cabinAttendantFilterMaxFlightCount = req.query.cabinAttendantFilterMaxFlightCount;

  let nameQuery = "";
  let minFlightCountQuery = "";
  let maxFlightCountQuery = "";

  let queryArr = [];
  if(cabinAttendantFilterNameValue !== "?"){
    nameQuery = " name = '" + cabinAttendantFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(cabinAttendantFilterMinFlightCount !== "-1"){
    minFlightCountQuery = " flight_count > " + parseInt(cabinAttendantFilterMinFlightCount) + "";
    queryArr.push(minFlightCountQuery);
  }
  if(cabinAttendantFilterMaxFlightCount !== "-1"){
    maxFlightCountQuery = " flight_count < " + parseInt(cabinAttendantFilterMaxFlightCount) + "";
    queryArr.push(maxFlightCountQuery);
  }

  let queryString = "";
  
  queryString = "SELECT employee.employee_id,person.name,employee.flight_count,person.lastname FROM employee JOIN person ON employee.ssn = person.ssn WHERE username = '" + username + "' AND employee.profession = 'cabin attendant' AND employee.status = 'free'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/flightAirplane", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let flightAirplaneType1Checked = req.query.flightAirplaneType1Checked;
  let flightAirplaneType2Checked = req.query.flightAirplaneType2Checked;
  let flightAirplaneType3Checked = req.query.flightAirplaneType3Checked;
  
  let type_one_Query = "";
  let type_two_Query = "";
  let type_three_Query = "";

  let queryArr = [];
  let typeArr = [];
  if(flightAirplaneType1Checked === "false" && flightAirplaneType2Checked === "false" && flightAirplaneType3Checked === "false"){
    flightAirplaneType1Checked = "true";
    flightAirplaneType2Checked = "true";
    flightAirplaneType3Checked = "true";
  }
  if(flightAirplaneType1Checked === "true"){
    type_one_Query = " plane.model_name = 'DEU-AIRLINES-A200'";
    typeArr.push(type_one_Query);
  }
  if(flightAirplaneType2Checked === "true"){
    type_two_Query = " plane.model_name = 'DEU-AIRLINES-A300'";
    typeArr.push(type_two_Query);
  }
  if(flightAirplaneType3Checked === "true"){
    type_three_Query = " plane.model_name = 'DEU-AIRLINES-A400'";
    typeArr.push(type_three_Query);
  }

  let  queryString = "SELECT plane.plane_id,plane.model_name,plane_type.a_class_capacity,plane_type.b_class_capacity,plane_type.price FROM plane JOIN plane_type ON plane.model_name = plane_type.model_name WHERE plane.username = '" + username + "' AND plane.status = 'free' AND";

  let typeString = " (";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      typeString += typeArr[i];
    }
    else{
      typeString += typeArr[i] + " OR";
    }
  }
  typeString += ")";
  queryString += typeString;

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/flightShow", (req, res) => {
  let first_last = req.query.first_last;
  let username = req.query.username;
  let flightShowFilterMinId = req.query.flightShowFilterMinId;  
  let flightShowFilterMaxId = req.query.flightShowFilterMaxId;
  
  let minFlightIdQuery = "";
  let maxFlightIdQuery = "";

  let queryArr = [];
  if(flightShowFilterMinId !== "-1"){
    minFlightIdQuery = " flight_id >= " + parseInt(flightShowFilterMinId) + "";
    queryArr.push(minFlightIdQuery);
  }
  if(flightShowFilterMaxId !== "-1"){
    maxFlightIdQuery = " flight_id <= " + parseInt(flightShowFilterMaxId) + "";
    queryArr.push(maxFlightIdQuery);
  }

  let queryString = "";
  
  queryString = "SELECT * FROM flight WHERE username = '" + username + "'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  
  if(first_last === "first"){
    queryString += " LIMIT 200";
  }
  else if(first_last === "last"){
    queryString += " LIMIT 200, 18446744073709551615";
  }

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/flightDetails", (req, res) => {
  let id = req.query.id;
  let queryString = "SELECT * FROM flight WHERE flight_id = '" + id + "'";
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getAirportDetails", (req, res) => {
  let id_1 = req.query.id.split(",")[0];
  let id_2 = req.query.id.split(",")[1];
  let queryString = "SELECT * FROM airport WHERE airport_id = '" + id_1 + "'";
  let queryString2 = "SELECT * FROM airport WHERE airport_id = '" + id_2 + "'";
  const dataArray = []; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
  });
  db.query(queryString2, function (error, result1, fields) {
    if (error) throw error;
    result1.forEach(row => {
      const rowArray1 = Object.values(row);
      dataArray.push(rowArray1);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getPilotsDetails", (req, res) => {
  let id_1 = req.query.id.split(",")[0];
  let id_2 = req.query.id.split(",")[1];
  let id_3 = req.query.id.split(",")[2];
  let typeArr = [];

  if(id_1 !== 'null'){
    typeArr.push(id_1);
  }
  if(id_2 !== 'null'){
    typeArr.push(id_2);
  }
  if(id_3 !== 'null'){
    typeArr.push(id_3);
  }

  let queryString = "SELECT * FROM employee JOIN person ON employee.ssn = person.ssn WHERE ";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      queryString += "employee.employee_id = '" + typeArr[i] + "'";
    }
    else{
      queryString += "employee.employee_id = '" + typeArr[i] + "' OR ";
    }
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getCabinAttendantsDetails", (req, res) => {
  let id_1 = req.query.id.split(",")[0];
  let id_2 = req.query.id.split(",")[1];
  let id_3 = req.query.id.split(",")[2];
  let id_4 = req.query.id.split(",")[3];
  let id_5 = req.query.id.split(",")[4];
  let typeArr = [];
  
  if(id_1 !== 'null'){
    typeArr.push(id_1);
  }
  if(id_2 !== 'null'){
    typeArr.push(id_2);
  }
  if(id_3 !== 'null'){
    typeArr.push(id_3);
  }
  if(id_4 !== 'null'){
    typeArr.push(id_4);
  }
  if(id_5 !== 'null'){
    typeArr.push(id_5);
  }

  let queryString = "SELECT * FROM employee JOIN person ON employee.ssn = person.ssn WHERE ";

  for(let i = 0; i < typeArr.length; i++){
    if(i === typeArr.length - 1){
      queryString += "employee.employee_id = '" + typeArr[i] + "'";
    }
    else{
      queryString += "employee.employee_id = '" + typeArr[i] + "' OR ";
    }
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getPassangersDetails", (req, res) => {
  let id = req.query.id;
  let passengerFilterNameValue = req.query.passengerFilterNameValue;
  let passengerFilterGenderValue = req.query.passengerFilterGenderValue; 

  let nameQuery = "";
  let genderQuery = "";

  let queryArr = [];
  if(passengerFilterNameValue !== "?"){
    nameQuery = " name = '" + passengerFilterNameValue + "'";
    queryArr.push(nameQuery);
  }
  if(passengerFilterGenderValue !== "?"){
    genderQuery = " gender = '" + passengerFilterGenderValue + "'";
    queryArr.push(genderQuery);
  }

  let queryString = "SELECT person.ssn, person.name, person.lastname, person.gender, person.birth_date FROM ticket JOIN person ON ticket.ssn = person.ssn WHERE ticket.flight_id = '" + id + "'";

  for(let i = 0; i < queryArr.length; i++){
    queryString += " AND" + queryArr[i];
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getPlaneDetails", (req, res) => {
  let id = req.query.id;
  let queryString = "SELECT plane.plane_id, plane.model_name, plane.flight_count, plane_type.a_class_capacity, plane_type.b_class_capacity FROM plane JOIN plane_type ON plane.model_name = plane_type.model_name WHERE plane.plane_id = '" + id + "'";
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/getPlaneOccupancyDetails", (req, res) => {
  let id = req.query.id;
  let queryString = "SELECT COUNT(*) FROM ticket WHERE flight_id = '" + id + "'";
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/nextHire", (req, res) => {
  let id_arr = req.query.id.split(",");
  let username = req.query.username;

  let queryString = "UPDATE employee SET username = '" + username + "' WHERE employee_id = ";
  for(let i = 0; i < id_arr.length; i++){
    if(i !== id_arr.length - 1){
      queryString += "'" + id_arr[i] + "' OR employee_id = ";
    }
    else{
      queryString += "'" + id_arr[i] + "'";
    }
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("a");
  });
});
app.get("/api/nextDismiss", async(req, res) => {
  let id_arr = req.query.id.split(",");
  let wrongIDs = [];
  for (let id of id_arr) {
    let queryString = "UPDATE employee SET username = 'admin' WHERE employee_id = '" + id + "'";
    try {
      await new Promise((resolve, reject) => {
        db.query(queryString, function (error, result) {
          if (error) {
            wrongIDs.push(id);
            reject(error);
          } else {
            resolve(result);
          }
        });
      });
    } catch (error) {
    }
  }
  return res.send(wrongIDs);
});
app.get("/api/nextBuyPlane", (req, res) => {
  let id_arr = req.query.id.split(",");
  let username = req.query.username;


  let queryString = "UPDATE plane SET username = '" + username + "' WHERE plane_id = "
  for(let i = 0; i < id_arr.length; i++){
    if(i !== id_arr.length - 1){
      queryString += "'" + id_arr[i] + "' OR plane_id = ";
    }
    else{
      queryString += "'" + id_arr[i] + "'";
    }
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("b");
  });
});
app.get("/api/nextSellPlane", async (req, res) => {
  let id_arr = req.query.id.split(",");
  let wrongIDs = [];
  for (let id of id_arr) {
    let queryString = "UPDATE plane SET username = 'admin' WHERE plane_id = '" + id + "'";
    try {
      await new Promise((resolve, reject) => {
        db.query(queryString, function (error, result) {
          if (error) {
            wrongIDs.push(id);
            reject(error);
          } else {
            resolve(result);
          }
        });
      });
    } catch (error) {
    }
  }
  return res.send(wrongIDs);
});
app.get("/api/nextUnlockAirport", (req, res) => {
  let id_arr = req.query.id.split(",");
  let username = req.query.username;
 
  let queryString = "INSERT INTO unlocked_airport (username, airport_id) VALUES ";

  for(let i = 0; i < id_arr.length; i++){
    if(i === id_arr.length - 1){
      queryString += "('" + username + "', '" + id_arr[i] + "')";
    }
    else{
      queryString += "('" + username + "', '" + id_arr[i] + "'),";
    }
  }
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("b");
  });
});
app.get("/api/nextFlight", (req, res) => {
  let take_off = req.query.take_off;
  let landing = req.query.landing;
  let pilot_id = req.query.pilot_id;
  let cabin_attendant_id = req.query.cabin_attendant_id;
  let plane = req.query.plane;
  let day = req.query.day;
  let username = req.query.username;

  let queryString = "INSERT INTO flight (username, take_off_airport_id, landing_airport_id, ";
  let queryStringEmployee = "UPDATE employee SET flight_count = flight_count + 1 WHERE ";
  let queryStringPlane = "UPDATE plane SET flight_count = flight_count + 1 WHERE plane_id = '" + plane + "'";

  if(pilot_id.split(",").length === 2){
    queryString += "pilot_1, pilot_2, ";
    queryStringEmployee += "employee_id = '" + pilot_id.split(",")[0] + "' OR employee_id = '" + pilot_id.split(",")[1] + "' OR ";
  }
  else{
    queryString += "pilot_1, pilot_2, pilot_3, ";
    queryStringEmployee += "employee_id = '" + pilot_id.split(",")[0] + "' OR employee_id = '" + pilot_id.split(",")[1] + "' OR " + "employee_id = '" + pilot_id.split(",")[2] + "' OR ";
  }
  if(cabin_attendant_id.split(",").length === 3){
    queryString += "cabin_attendant_1, cabin_attendant_2, cabin_attendant_3, "; 
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "'";
  }
  else if(cabin_attendant_id.split(",").length === 4){
    queryString += "cabin_attendant_1, cabin_attendant_2, cabin_attendant_3, cabin_attendant_4, "; 
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[3] + "'";
  }
  else{
    queryString += "cabin_attendant_1, cabin_attendant_2, cabin_attendant_3, cabin_attendant_4, cabin_attendant_5, "; 
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[3] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[4] + "'";
  }
  queryString += "plane_id, day) VALUES ('" + username + "','" + take_off + "','" + landing + "',";

  if(pilot_id.split(",").length === 2){
    queryString += "'" + pilot_id.split(",")[0] + "','" + pilot_id.split(",")[1];
  }
  else{
    queryString += "'" + pilot_id.split(",")[0] + "','" + pilot_id.split(",")[1] + "','" + pilot_id.split(",")[2];
  }
  if(cabin_attendant_id.split(",").length === 3){
    queryString += "','" + cabin_attendant_id.split(",")[0] + "','" + cabin_attendant_id.split(",")[1] + "','" + cabin_attendant_id.split(",")[2] + "','";
  }
  else if(cabin_attendant_id.split(",").length === 4){
    queryString += "','" + cabin_attendant_id.split(",")[0] + "','" + cabin_attendant_id.split(",")[1] + "','" + cabin_attendant_id.split(",")[2] + "','" + cabin_attendant_id.split(",")[3] + "','";
  }
  else{
    queryString += "','" + cabin_attendant_id.split(",")[0] + "','" + cabin_attendant_id.split(",")[1] + "','" + cabin_attendant_id.split(",")[2] + "','" + cabin_attendant_id.split(",")[3] + "','" + cabin_attendant_id.split(",")[4] + "','"; 
  }

  queryString +=  plane + "','" + day + "')";
  
  db.query(queryStringEmployee, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryStringPlane, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("b");
  });
});
app.get("/api/nextSetFree", (req, res) => {
  let day = req.query.day;
  let money = req.query.money;
  let username = req.query.username;
  let queryString = "UPDATE plane SET status = 'free' WHERE status = 'onflight'";
  let queryString2 = "UPDATE employee SET status = 'free' WHERE status = 'onflight'";
  let queryString3 = "UPDATE person SET flight_status = '0' WHERE flight_status = '1'";
  let queryStringDay = "UPDATE player SET day = '" + day + "' WHERE username = '" + username + "'";
  let queryStringMoney = "UPDATE player SET money = '" + money + "' WHERE username = '" + username + "'";
  let queryStringBank = "UPDATE taken_loan SET remaining_day = remaining_day - 1 WHERE username = '" + username + "' AND remaining_day > -1";

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryString3, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryStringDay, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryStringMoney, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryStringBank, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryString2, function (error, result, fields) {
    if (error) throw error;
    return res.send("b");
  });
});


app.get("/api/getFCAndProfession", (req, res) => {
let username = req.query.username;
  let queryString = "SELECT profession, flight_count FROM employee WHERE username = '" + username + "'";

  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});


app.get("/api/createTicket", (req, res) => {
  let ticketNumber = req.query.ticketNumber;
  let price = req.query.price;
  let max_id = 0;

  let getMaxIdQuery = "SELECT flight_id FROM flight ORDER BY flight_id DESC LIMIT 1";
  let randomSsnQuery = "SELECT ssn FROM person WHERE flight_status != '1' ORDER BY RAND() LIMIT " + ticketNumber;

  db.query(getMaxIdQuery, function (error, result, fields) {
    if (error) throw error;
    max_id = result[0].flight_id;
      db.query(randomSsnQuery, function (error, result, fields) {
        if (error) throw error;
        const ssnArray = []; 
        result.forEach(row => {
        const rowArray = Object.values(row);
        ssnArray.push(rowArray);
        });
        for(let i = 0; i < ssnArray.length ; i++){
          let createTicket = "INSERT INTO ticket (ssn, flight_id, price) VALUES ('" + ssnArray[i] + "', '" + max_id + "', '" + price + "')";
          db.query(createTicket, function (error, result, fields) {
            if (error) throw error;
            let setSsnStatus = "UPDATE person SET flight_status = '1' WHERE ssn = '" + ssnArray[i] + "'";
            db.query(setSsnStatus, function (error, result, fields) {
              if (error) throw error;
            });
          });
        }
      });    
      return res.send("a");  
  });
});


app.get("/api/bankCredit", (req, res) => {
  let username = req.query.username;
  let queryString = "SELECT taken_loan.credit_amount, taken_loan.remaining_day, credit_type.interest_rate, credit_type.day FROM taken_loan JOIN credit_type ON taken_loan.credit_amount = credit_type.credit_amount WHERE username = '" + username + "' AND taken_loan.remaining_day >= 0"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/isAnyActiveCredit", (req, res) => {
  let username = req.query.username;
  let queryString = "SELECT credit_amount FROM taken_loan WHERE username = '" + username + "' AND taken_loan.remaining_day >= 0"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/loan", (req, res) => {
  let username = req.query.username;
  let credit_amount = req.query.credit_amount;
  let day = req.query.day;
  let queryString = "INSERT INTO taken_loan (username, credit_amount, remaining_day) VALUES ('" + username + "', '" + credit_amount + "', '" + day +"')"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("a");
  });
});


app.get("/api/setFlightStatus", (req, res) => {
  let pilot_id = req.query.pilot_id;
  let cabin_attendant_id = req.query.cabin_id;
  let plane_id = req.query.plane_id;

  let queryStringEmployee = "UPDATE employee SET status = 'onflight' WHERE ";
  let queryStringPlane = "UPDATE plane SET status = 'onflight' WHERE plane_id = '" + plane_id + "'";

  if(pilot_id.split(",").length === 2){
    queryStringEmployee += "employee_id = '" + pilot_id.split(",")[0] + "' OR employee_id = '" + pilot_id.split(",")[1] + "' OR ";
  }
  else{
    queryStringEmployee += "employee_id = '" + pilot_id.split(",")[0] + "' OR employee_id = '" + pilot_id.split(",")[1] + "' OR " + "employee_id = '" + pilot_id.split(",")[2] + "' OR ";
  }
  if(cabin_attendant_id.split(",").length === 3){
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "'";
  }
  else if(cabin_attendant_id.split(",").length === 4){
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[3] + "'";
  }
  else{
    queryStringEmployee += "employee_id = '" + cabin_attendant_id.split(",")[0] + "' OR employee_id = '" + cabin_attendant_id.split(",")[1] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[2] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[3] + "' OR " + "employee_id = '" + cabin_attendant_id.split(",")[4] + "'";
  }

  db.query(queryStringEmployee, function (error, result, fields) {
    if (error) throw error;
  });
  db.query(queryStringPlane, function (error, result, fields) {
    if (error) throw error;
    return res.send("a");
  });
});

app.get("/api/insertDayLog", (req, res) => {
  let username = req.query.username;
  let day = req.query.day;
  let log = req.query.dayLog;
  let queryString = "INSERT INTO day_log (username, day, log) VALUES ('" + username + "', '" + day + "', '" + log + "')"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("a");
  });
});
app.get("/api/getDayLog", (req, res) => {
  let username = req.query.username;
  let day = req.query.day;
  let queryString = "SELECT log FROM day_log WHERE username = '" + username + "' AND day = '" + day + "'"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    const dataArray = []; 
    result.forEach(row => {
      const rowArray = Object.values(row);
      dataArray.push(rowArray);
    });
    return res.send(dataArray);
  });
});
app.get("/api/giveFeedback", (req, res) => {
  let feedbackBody = req.query.feedbackBody;
  let feedbackHeader = req.query.feedbackHeader;
  let queryString = "INSERT INTO feedback (feedback_header, feedback_body) VALUES ('" + feedbackHeader + "', '" + feedbackBody + "')"; 
  db.query(queryString, function (error, result, fields) {
    if (error) throw error;
    return res.send("a");
  });
});


app.listen(5001, () => {
  console.log("Server started...");
});




//The following codes are used to fill the database randomly while creating the game. It is one time only.

/*db.query("SELECT ssn FROM person WHERE birth_date > '1975.1.1' AND birth_date < '1995.1.1' LIMIT 10000", function(error, result, fields) {
  if (error) throw error;
  const dataArray = []; 
  result.forEach(row => {
    const rowArray = Object.values(row);
    dataArray.push(rowArray[0]);
  });
  const fs = require('fs');
  const fileContent = dataArray.join('\n'); // Diziyi satır satır birleştir
  fs.writeFile("ssn.txt", fileContent, err => {
  if (err) {
    console.error('Hata oluştu:', err);
    return;
  }
  console.log('Dosya başarıyla yazıldı:', "ssn.txt");
});
});
*/

/*
const fs = require('fs');
let satirlar;
fs.readFile("insertPeople.txt", 'utf8', (err, data) => {
  if (err) {
    console.error('Dosya okunurken bir hata oluştu:', err);
    return;
  }
  satirlar = data.split('\n');
  db.connect((error) => {
    if (error) {
      console.log('Veritabanına bağlanırken hata oluştu:', error);
      return;
    }
    for (let i = 277941; i < 999999; i++) {
      db.query(satirlar[i], function (error, result, fields) {
        console.log(i);
        if (error) throw error;
      });
    }
  });
});
*/

/*
const fs = require('fs');
let satirlar;
fs.readFile("employee.txt", 'utf8', (err, data) => {
  if (err) {
    console.error('Dosya okunurken bir hata oluştu:', err);
    return;
  }
  satirlar = data.split('\n');
  db.connect((error) => {
    if (error) {
      console.log('Veritabanına bağlanırken hata oluştu:', error);
      return;
    }
    for (let i = 0; i < 50000; i++) {
      db.query(satirlar[i], function (error, result, fields) {
        console.log(i);
        if (error) throw error;
      });
    }
  });
});*/
