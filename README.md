# WorkerHealthChecks

WorkerHealthChecks is a lightweight library designed to facilitate health checks in worker applications. It provides a simple and flexible way to monitor the health of your services and notify subscribers when the system is not healthy.

## Purpose

The purpose of WorkerHealthChecks is to:

- Monitor the health of worker services.
- Notify subscribers when the system is not healthy.
- Provide a customizable and extensible solution for handling health checks.

## Features

- **Health Monitoring**: Continuously monitors the health of worker services.
- **Customizable**: Allows you to define custom health checks based on your specific requirements.
- **Notification**: Notifies subscribers when the system is not healthy, allowing for prompt action.
- **Easy Integration**: Integrates seamlessly into worker applications with minimal setup.

## Installation

You can install WorkerHealthChecks via NuGet Package Manager. Simply run the following command:

```bash
dotnet add package WorkerHealthChecks
```

## Usage

Check [WorkerHealthChecks.Sample](./WorkerHealthChecks.Sample/) that implements an example using health checks on an API and using a sample worker to simulate when a worker captures an error like database connection or another external service failure

## Contributing

Contributions are welcome! If you encounter any bugs or have suggestions for improvements, please open an issue or submit a pull request on GitHub.

## License

This project is licensed under the [GNU License](LICENSE).
