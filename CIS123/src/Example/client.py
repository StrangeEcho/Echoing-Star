import socket


def client_program() -> None:
    host = "127.0.0.1"  # get hostname for the client. Will be the same as the server in our case
    port = 5000  # socket server port number

    client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)  # Initiate our socket tunnel
    print("Attempting socket connection...\n\n")
    try:
        client_socket.connect((host, port))  # Connect to our server
        print(f"Client socket connection established at: {host}:{port}")
    except socket.error as e:
        print(f"Error while attempting to connect socket {e}")


    message = input("-> ") # Input to send to the server  

    while True:
        client_socket.send(message.encode())  # send message
        data = client_socket.recv(1024).decode()  # receive response
        
        if not data:
            break # No data recieved

        print(f"Recieved from the server across socket tunnel:\n{data}")

        message = input("-> ") # Keep accepting data to send
    
    client_socket.close()  # close the connection upon loop breaking


if __name__ == '__main__':
    client_program()
