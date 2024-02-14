# Namma Dinner API

- [Namma Dinner API](#namma-dinner-api)
  - [Auth](#auth)
	- [Register](#register)
		- [Register Request](#register-request)
		- [Register Response](#register-response)
	- [Login](#login)
	  - [Login Request](#login-request)
	  - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
	"firstName": "roopesh",
	"lastName": "gb",
	"email": "rgb@gmail.com",
	"password": "rgb@123"

}
```

#### Register Response

```json
{
	"id": "ad89c749-eb3a",
	"firstName": "roopesh",
	"lastName": "gb",
	"email": "rgb@gmail.com",
	"token": "7fd3123"

}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request
```json
{
	"email": "roopesh",
	"password": "rgb@123"
}
```

#### Login Response
```json
{
	"IsSuccess": true,
	"ErrorMessage": null
}
```