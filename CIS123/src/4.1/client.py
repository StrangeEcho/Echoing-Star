import socket


def client_program():
    host = socket.gethostname()  # get hostname for the client. Will be the same as the server in our case
    port = 5000  # socket server port number

    client_socket = socket.socket(socket.AF_INET6, socket.SOCK_STREAM)  # Initiate our socket tunnel
    client_socket.connect((host, port))  # Connect to our server
    print(f"Client socket connection established via: {host}:{port}")

    message = input("-> ") # Input to send to the server  

    while message.lower().strip() != 'bye':
        client_socket.send(message.encode())  # send message
        data = client_socket.recv(1024).decode()  # receive response
        
        if not data:
            break # No data recieved

        print(f"Recieved from the server across socket tunnel: {data}")

        message = input("-> ") # Keep accepting data to send

    client_socket.close()  # close the connection upon loop breaking


if __name__ == '__main__':
    client_program()
