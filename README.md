# ProjectAsp
Attempt1
Role authorization helps controll access to information. Everybody can see only that they should see




Databse schema
![2020-07-24](https://user-images.githubusercontent.com/56975146/88403241-4be24880-cd9a-11ea-9a6c-e51cfeb2c409.png)




MVC screenshort

![2020-07-24 (1)](https://user-images.githubusercontent.com/56975146/88403461-96fc5b80-cd9a-11ea-93c6-b73c80510eee.png)
![2020-07-24 (2)](https://user-images.githubusercontent.com/56975146/88403464-9794f200-cd9a-11ea-8303-5840e1df7c5a.png)
![2020-07-24 (3)](https://user-images.githubusercontent.com/56975146/88403470-98c61f00-cd9a-11ea-9567-bd3fd05d878b.png)
![2020-07-24 (4)](https://user-images.githubusercontent.com/56975146/88403471-98c61f00-cd9a-11ea-8d86-5d90b20a3938.png)



Role Authorization:
1)In AddrController only Editor can see details of addresses and edit it
2)admin can see almost all links in nav bar except address; Editor and Delivery service can see only home, private and addresse page
3)   There are three roles:
    1. admin, who can create new roles and see role list, and has access to Order and Customer information;
    2. Delivery service, who can see address information
    3. Editor, who can see datails of addresses and edit it.
