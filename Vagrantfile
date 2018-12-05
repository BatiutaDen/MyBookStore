
Vagrant.configure("2") do |config|
  
  config.vm.box = "TestDemo"
  config.vm.synced_folder  'C:\\Users\\dbat\\source\\repos\\BatiutaDen\\MyBookStore' , '/var/www/', create: true
  config.vm.box_url = "jacqinthebox/windowsserver2016" 
  config.vm.guest = :windows
  config.vm.communicator = "winrm"
  
  config.vm.provider "virtualbox" do |vagTest|
   
   vagTest.memory = "2048"
   
  end
 
   config.vm.provision "shell", path: 'iis_settings.ps1', privileged: true
 
   
end
