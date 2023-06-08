<div align="center">
  <a href="http://www.mayaramein.com/"><img src="https://i.imgur.com/8EekJZH.png" width=150  /></a>

  ## Backend .NET Development

 ![](https://img.shields.io/badge/C%23-ebdcff?style=flat&logo=csharp&logoColor=black) ![](https://img.shields.io/badge/.NET-ebdcff?style=flat&logo=dotnet&logoColor=black) ![](https://img.shields.io/badge/Microservices-ebdcff?style=flat&logo=dotnet&logoColor=black) ![](https://img.shields.io/badge/MongoDB-ebdcff?style=flat&logo=mongodb&logoColor=black) ![](https://img.shields.io/badge/Docker-ebdcff?style=flat&logo=docker&logoColor=black) 
  
  
  
 

  </div>

# Microservices Project

This project implements a microservices architecture using .NET 7, MongoDB, and Docker. It consists of multiple microservices, each responsible for a specific module of the application.

## Architecture Overview

The project follows a microservices architecture, which offers scalability, modularity, and flexibility. The key components of the architecture include:

- Microservices: Each microservice focuses on a specific business capability and communicates with other services through APIs.
- API Gateway: Acts as a single entry point for clients and handles API routing, authentication, and other cross-cutting concerns.
- Service Discovery: Enables services to discover and communicate with each other dynamically.
- Message Brokers: Used for asynchronous communication between services.
- Centralized Logging and Monitoring: Provides monitoring and troubleshooting capabilities for the microservices environment.

## Catalog Microservice

The catalog microservice is responsible for managing categories and products. It leverages MongoDB for data storage and retrieval.

### Features

- Create, retrieve, update, and delete categories.
- Create, retrieve, update, and delete products.
- Search for products by category, name, or other criteria.
- Maintain relationships between categories and products.
- Ensure data consistency and integrity through validation and business rules.

### Technologies Used

- .NET 7
- MongoDB
- Docker

## Getting Started

To run the catalog microservice locally, follow these steps:

1. Clone the repository: `git clone https://github.com/mayaramein/Microservices.NET.Docker.git`
2. Navigate to the catalog microservice directory: `cd catalog.api`
3. Install the dependencies: `dotnet restore`
4. Configure the MongoDB connection settings in the `appsettings.json` file.
5. Build the project: `dotnet build`
6. Run the migrations (if applicable): `dotnet ef database update`
7. Start the microservice: `dotnet run`

The catalog microservice should now be up and running on your local machine.

## API Documentation

The API documentation for the catalog microservice can be accessed through the Swagger UI. Once the microservice is running, open your web browser and navigate to `http://localhost:<port>/swagger` to view and interact with the API endpoints.

<!-- ## Docker Deployment

To deploy the catalog microservice using Docker, follow these steps:

1. Build the Docker image: `docker build -t catalog-microservice .`
2. Run the Docker container: `docker run -p <host-port>:<container-port> catalog-microservice` -->

<!-- The catalog microservice will be running inside a Docker container and accessible through the specified host port. -->

## Contributing

To contribute, follow these steps:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-feature-name`
3. Make your changes and commit them: `git commit -am 'Add new feature'`
4. Push the changes to your fork: `git push origin feature/your-feature-name`
5. Submit a pull request describing your changes.

Please ensure that your code follows the project's coding standards and includes appropriate tests.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

<div align="center">
 <a href="http://www.mayaramein.com/"><img src="https://i.imgur.com/QwGkBal.png"  width=120  /></a>
 
![](https://img.shields.io/badge/Data_Scientist-ebdcff?style=flat) ![](https://img.shields.io/badge/Software_Engineer-ebdcff?style=flat)  ![](https://img.shields.io/badge/Full_Stack_Web_Developer-ebdcff?style=flat)  


  [![](https://img.shields.io/badge/Microsoft_Outlook-ffcb33?style=for-the-badge&logo=microsoft-outlook&logoColor=black)](mailto:mayaramein@outlook.com) [![](https://img.shields.io/badge/website-ffcb33?style=for-the-badge&logo=About.me&logoColor=black)](https://mayaramein.com)
[![](https://img.shields.io/badge/LinkedIn-ffcb33?style=for-the-badge&logo=linkedin&logoColor=black)](https://linkedin.com/in/mayaramein) 

</div>


## Acknowledgements
Special thanks to Eng.Mohamed Elsaeed Elsakhawy for the YouTube playlist:

- [YouTube Playlist](https://www.youtube.com/playlist?list=PLr063twoHjULJ866OnydSAwA5bmRxwgi6)

Thanks for providing valuable content and resources!
