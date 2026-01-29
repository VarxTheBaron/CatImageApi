### Routes

GET /api/cats - Random cat image


GET /api/cats?b={breed} - random cat image of cat within specified category
GET /api/cats?a={amount} - random x amount of cat images
GET /api/cats?w={weather} - random image of cat within weather category 
GET /api/cats?b={breed}&&a={amount} - random x amount of cat images within specified category

GET /api/cats/facts - random cat facts

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
  "Description": "Nice ragdoll kitty",
  "Breed": "Ragdoll",
  "Weather": "Sunshine"
}

### GET fact example
{
  "Fact": "Cats are cool."
}
