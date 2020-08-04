#include "main.h"
#include "stm32f4xx_hal.h"
#include "dma.h"
#include "tim.h"
#include "usart.h"
#include "usb_device.h"
#include "gpio.h"
#include "stepperdef.h"
#include "usbd_cdc_if.h"

stepper stepperA;
stepper stepperB;
stepper stepperC;

char stop[5] = "STOP\n";
char C1[2] = "1\n";
char C2[2] = "2\n";
char C3[2] = "3\n";
char C4[2] = "4\n";
char C5[2] = "5\n";
char C6[2] = "6\n";
char C7[2] = "7\n";
char buffF[20];

bool buzzer = false;

bool calib = false;
int state = 1;

void SystemClock_Config(void);

int main(void)
{
  stepperA.periodps = 999;
	stepperB.periodps = 999;
	stepperC.periodps = 999;
	
	memset(&buffF, 0, sizeof(buffF));
	
  HAL_Init();

  SystemClock_Config();

  MX_GPIO_Init();
  MX_DMA_Init();
  MX_USB_DEVICE_Init();
  MX_TIM2_Init();
  MX_TIM3_Init();
  MX_TIM5_Init();
  MX_TIM4_Init();
	MX_TIM9_Init();
  MX_USART1_UART_Init();
	
	htim2.Instance->CCR1 = 50;
	htim3.Instance->CCR3 = 50;
	htim5.Instance->CCR3 = 50;
	
	HAL_GPIO_WritePin(DRV_A_RST_GPIO_Port, DRV_A_RST_Pin, GPIO_PIN_SET);
	HAL_GPIO_WritePin(DRV_B_RST_GPIO_Port, DRV_B_RST_Pin, GPIO_PIN_SET);
	HAL_GPIO_WritePin(DRV_C_RST_GPIO_Port, DRV_C_RST_Pin, GPIO_PIN_SET);
	
	HAL_GPIO_WritePin(LS_A_OUT_GPIO_Port, LS_A_OUT_Pin, GPIO_PIN_SET);
	HAL_GPIO_WritePin(LS_B_OUT_GPIO_Port, LS_B_OUT_Pin, GPIO_PIN_SET);
	HAL_GPIO_WritePin(LS_C_OUT_GPIO_Port, LS_C_OUT_Pin, GPIO_PIN_SET);
	
	HAL_GPIO_WritePin(RELAY_1_GPIO_Port, RELAY_1_Pin, GPIO_PIN_SET);

  while (1)
  {			
		if(calib == true)
		{
			if(HAL_GPIO_ReadPin(LS_B_IN_GPIO_Port, LS_B_IN_Pin) == 0 && state == 1)
			{
				state = 2;
				HAL_GPIO_WritePin(LS_B_OUT_GPIO_Port, LS_B_OUT_Pin, GPIO_PIN_RESET);
				HAL_Delay(100);
				HAL_TIM_PWM_Stop(&htim2, TIM_CHANNEL_1);
				CDC_Transmit_FS((uint8_t *)C2, 2);				
			}
			else if(HAL_GPIO_ReadPin(LS_C_IN_GPIO_Port, LS_C_IN_Pin) == 0 && state == 3)
			{
				state  = 4;
				HAL_GPIO_WritePin(LS_C_OUT_GPIO_Port, LS_C_OUT_Pin, GPIO_PIN_RESET);
				HAL_Delay(100);
				HAL_TIM_PWM_Stop(&htim3, TIM_CHANNEL_3);
				CDC_Transmit_FS((uint8_t *)C4, 2);
			}
			else if(HAL_GPIO_ReadPin(LS_A_IN_GPIO_Port, LS_A_IN_Pin) == 0 && state == 5)
			{
				state = 6;
				HAL_GPIO_WritePin(LS_A_OUT_GPIO_Port, LS_A_OUT_Pin, GPIO_PIN_RESET);
				HAL_Delay(100);
				HAL_TIM_PWM_Stop(&htim5, TIM_CHANNEL_3);
				CDC_Transmit_FS((uint8_t *)C6, 2);
			}
			else
				;
		}
  }
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{

  RCC_OscInitTypeDef RCC_OscInitStruct;
  RCC_ClkInitTypeDef RCC_ClkInitStruct;

    /**Configure the main internal regulator output voltage 
    */
  __HAL_RCC_PWR_CLK_ENABLE();

  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);

    /**Initializes the CPU, AHB and APB busses clocks 
    */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 4;
  RCC_OscInitStruct.PLL.PLLN = 96;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 4;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

    /**Initializes the CPU, AHB and APB busses clocks 
    */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_3) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

    /**Configure the Systick interrupt time 
    */
  HAL_SYSTICK_Config(HAL_RCC_GetHCLKFreq()/1000);

    /**Configure the Systick 
    */
  HAL_SYSTICK_CLKSourceConfig(SYSTICK_CLKSOURCE_HCLK);

  /* SysTick_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(SysTick_IRQn, 0, 0);
}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @param  file: The file name as string.
  * @param  line: The line in file as a number.
  * @retval None
  */
void _Error_Handler(char *file, int line)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  while(1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t* file, uint32_t line)
{ 
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     tex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/**
  * @}
  */

/**
  * @}
  */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
