echo "enter 1st no"
read var1
echo "enter 2nd no"
read var2
echo 1 for +
echo 2 for -
echo 3 for *
echo 4 for /
read input
if [ $input -eq  1 ]
then
	echo $(($var1+$var2))
else
	echo invalid_option
fi
