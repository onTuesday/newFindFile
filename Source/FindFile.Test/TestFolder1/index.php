	<?php
	 print "<html>"."\n"."<head>"."\n"."<title>���������</title>"."<link rel=\"stylesheet\" type=\"text/css\" href=\"nbproject\main.css\"/>"."\n"."<title>���������</title>"."\n"."</head>"."\n"."</head>"."\n"."<body>";
	 //�����
     require_once 'form.php';
        
     //��������� ���������  
     if($_SERVER['REQUEST_METHOD'] == 'POST')
        {
        print "<table>"."\n";
        print "<tr>"."\n";
        $daysArr = array('��','��','��','��','��','��','��');
        foreach ($daysArr as $day) 
         print "<td class = \"days\">{$day}</td>"."\n";
        print "</tr>" . "\n";
        $month = $_POST['month'];
        $year = $_POST['year'];
        $day_counter = 1;
        $first_day = getDay(1,$month,$year);
        $key = 0;
        $current_date = [date('d'), date('m'), date('y')];
		$leng_of_month = cal_days_in_month(CAL_GREGORIAN , $month , $year);
        print "<tr>"."\n";
        for($i = 1; $i<=42; $i++)
        {
          if($i % 7 == 1 or $i == 1)
              print("<tr>"."\n");
		  $key = checkDay($i - $first_day + 1, $month, $day_counter, $leng_of_month);
		  print_td($i - $first_day + 1,$key);
          if($i % 7 == 0)
          {
              print("</tr>"."\n");
              $day_counter = 1;
          }
          ++$day_counter;
        }

        print('</table></br>');
        }
		//�������
        function  getDay($day, $mon , $year)
        /*��������� ��� ������
         * 1 - �����������
         * 2 - �������
         * 3 - �����
         * 4 - �������
         * 5 - �������
         * 6 - �������
         * 7 - �����������
         */
        {
		$daysArr = [7,1,2,3,4,5,6];
		$day = (int)$day; 
		$mon = (int)$mon;  
		$a = (int)((14 - $mon) / 12);
		$y = $year - $a;
		$m = $mon + 12 * $a - 2;
		$d = ((int)($day+$y+ (int)($y/4) - (int)($y/100) + (int)($y/400) + (31*$m)/12))%7;
		return $daysArr[$d] ;
        }
        
		//������� ������� � ����������� �� ���
        function print_td($val, $key = 0)
        {
            switch($key)
            {
                case 0:
                    print"<td class = \"default\"></td>  "."\n";//������ ��� ������
                    break;
                case 1:
                    print"<td class = \"default\">{$val}</td> "."\n";//������ ����
                    break;
                case 2:
                    print "<td class = \"day_off\">{$val}</td> "."\n";//��������
                    break;
                case 3:
                    print"<td class = \"holiday\">{$val}</td>"."\n";//��������
                    break;   
            }
        }
		
        //���������� ���� � ����������� �� ���
         function checkDay( $date , $month , $day, $leng)
         {
            $holidaysArr = [[1,1],[8,3],[23,2],[1,5],[9,5]];
            $dateArr = [$date,$month];
			foreach( $holidaysArr as $elem)
				 if ( $dateArr == $elem )
					 return 3;
			if(($day == 7 or $day == 8) and ( $date <= $leng  ) )
				return 2;
			if( $date < 1 or $date > $leng)
				return 0;
             return 1;
         }
		print "</body>"."\n";
		print "</html>"."\n";
		 ?>

