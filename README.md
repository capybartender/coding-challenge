## Coding Challenge (Appointment Booking)

### How to run the API:

Run the following command from the root directory, where `compose.yaml` is:
```bash
docker compose up
```
or

```bash
docker compose up -d
```
This will build and start a container with the API and DB inside.


### How to run the xUnit tests:

Run the following command from the root directory, where `Enpal.CodingChallenge.sln` is:

```bash
dotnet test
```

### How to run the js client tests:

Go to the `test-app` subdirectory and run the following commands:

```bash
npm install
npm run test
```