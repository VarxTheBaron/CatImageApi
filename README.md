### Routes

GET /api/cats - Random cat image

GET /api/cats/category
GET /api/cats/category?b={breed} - random cat image of cat within specified category
GET /api/cats/category?a={amount} - random x amount of cat images
GET /api/cats/category?w={weather} - random image of cat within weather category 
GET /api/cats/category?b={breed}&&a={amount} - random x amount of cat images within specified category

GET /api/cats/facts - random cat facts
GET /api/cats/facts?b={breed} - random breed facts

POST /api/cats - tar emot JSON data (se nedan) för att lägga in katter i databasen

```JSON
### GET example
{
  "Url": "https://upload.wikimedia.org/wikipedia/commons/c/c2/Ragdoll%2C_seal_mitted.JPG",
  "Description": "Nice ragdoll kitty"
}

### POST example

{
  "Url": "https://upload.wikimedia.org/wikipedia/commons/c/c2/Ragdoll%2C_seal_mitted.JPG",
  "Description": "Nice ragdoll kitty"
}
