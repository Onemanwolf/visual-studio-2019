//@ts-check
let message = 'Message for you';
let req = 'http://endpoint';
//"http://endpoint"
fetch(req)
  .then(response => response.json())
  .then(json => console.log(json));
for (let i = 0; i < message.length; i++) {
  console.log(message[i]);
}
//Implicit "javascript.implicitProjectConfig.checkJs": false,