#!/usr/bin/env python3
"""
Gerador de Código QR
Este programa gera códigos QR a partir de URLs/links
"""

import qrcode
import sys
from typing import Optional


def gerar_codigo_qr(link: str, arquivo_saida: str = "codigoqr.png") -> bool:
    """
    Gera um código QR a partir de um link fornecido e salva como arquivo de imagem.
    
    Args:
        link (str): A URL ou texto a ser codificado no código QR
        arquivo_saida (str): O nome do arquivo de saída (padrão: codigoqr.png)
    
    Returns:
        bool: Verdadeiro se bem-sucedido, Falso caso contrário
    """
    try:
        # Criar instância do código QR
        qr = qrcode.QRCode(
            version=1,  # Controla o tamanho do código QR
            error_correction=qrcode.constants.ERROR_CORRECT_L,
            box_size=10,
            border=4,
        )
        
        # Adicionar dados ao código QR
        qr.add_data(link)
        qr.make(fit=True)
        
        # Criar imagem
        img = qr.make_image(fill_color="preto", back_color="branco")
        
        # Salvar a imagem
        img.save(arquivo_saida)
        print(f"✓ Código QR gerado com sucesso: {arquivo_saida}")
        return True
        
    except Exception as e:
        print(f"✗ Erro ao gerar código QR: {e}", file=sys.stderr)
        return False


def principal():
    """Função principal para lidar com argumentos de linha de comando"""
    
    # Verificar se o link foi fornecido
    if len(sys.argv) < 2:
        print("Uso: python gerador_codigo_qr.py <link> [arquivo_saida]")
        print("\nExemplo:")
        print("  python gerador_codigo_qr.py https://github.com")
        print("  python gerador_codigo_qr.py https://github.com meu_codigoqr.png")
        sys.exit(1)
    
    link = sys.argv[1]
    arquivo_saida = sys.argv[2] if len(sys.argv) > 2 else "codigoqr.png"
    
    # Validar link
    if not link.strip():
        print("✗ Erro: O link não pode estar vazio", file=sys.stderr)
        sys.exit(1)
    
    # Gerar código QR
    sucesso = gerar_codigo_qr(link, arquivo_saida)
    sys.exit(0 if sucesso else 1)


if __name__ == "__main__":
    principal()
