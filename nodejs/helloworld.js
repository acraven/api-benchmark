'use strict'

const express = require('express')  
const app = express()
const bodyParser = require('body-parser');
const port = process.env.PORT || 8110

app.use(bodyParser.json())

app.get('/ping', (request, response) => { 
  response.contentType('text/plain');
  response.status(200).send('Pong!').end
})

app.listen(port, (err) => {  
  if (err) {
    console.log(err)
    process.exit(1)
  }

  console.log(`server is listening on ${port}`)
})
